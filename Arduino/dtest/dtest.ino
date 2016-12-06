#include <FastLED.h>
#include <SimpleTimer.h>
#define NUM_LEDS 23
#define DATA_PIN 13

CRGB leds[NUM_LEDS];
byte rgbData[NUM_LEDS*3];
int rgbDataLength;

bool reading = false;
int i = 0;

// set mode
// 0 = default/normal; 1 = blending
int mode = 1;
int blendvalue = 255;
int blendup = 1;

SimpleTimer timer;

void setup() {
  
  // Initalisiere LEDs
  FastLED.addLeds<NEOPIXEL, DATA_PIN>(leds, NUM_LEDS);
  rgbDataLength = NUM_LEDS*3;
  
  
  //TESTS
  FastLED.setDither(0);
  //FastLED.setBrightness(25);
  
  // Set starting color of LEDs
  int i;
  for (i = 0; i < NUM_LEDS*3; i = i+3)
  {
    rgbData[i] = 0x50; // r value
    rgbData[i+1] = 0xFF; // g value
    rgbData[i+2] = 0x00; // b value
  }
  ledUpdate();
  
  // Starte Connection
  Serial.begin(115200);
  //Serial.begin(115200,SERIAL_8E1);
  //while (!Serial) {
  //  ; // wait for serial port to connect. Needed for Leonardo only
  //}
  
  timer.setInterval(50, ledUpdate);
}

void ledUpdate()
{
  //Serial.print("Updating values");
  
  int j;
  
  if (mode == 1)
  {
    if (blendup == 1)
    {
      blendvalue -= 2;
      
      if (blendvalue < 5)
      {
        blendup = 2;
        Serial.print("Switch up");
      }
    }
    else if (blendup == 2)
    {
      blendvalue += 2;
      
      if (blendvalue > 250)
      {
        blendup = 1;
        Serial.print("Switch down");
      }
    }
    Serial.print("Blend value ");
    Serial.print(blendvalue);
  }

  for (j = 0; j < NUM_LEDS; j++)
  {
    
    //Serial.print(j);
    //Serial.print(":");
    //Serial.print(rgbData[j],HEX);
    //Serial.print(":");
    //Serial.print(rgbData[j+1],HEX);
    //Serial.print(":");
    //Serial.print(rgbData[j+2],HEX);
    //Serial.print(":");
    
    if (mode == 1)
    {
      leds[j].setRGB(scale8(rgbData[3*j], blendvalue),scale8(rgbData[3*j+1], blendvalue),scale8(rgbData[3*j+2], blendvalue));
    }
    else
    {
      leds[j].setRGB(rgbData[3*j],rgbData[3*j+1],rgbData[3*j+2]);
    }
 
    //leds[j] = rgbData[j];
    
  }
  FastLED.show(); 
}

void serialOutput(){
}
void loop() {
  
  //while(Serial.available() > 0 )
  while(true)
  {
    byte input = Serial.read();
  
    // readingmode
    if (input == 0x01)
    {
        Serial.println("");
        Serial.println("START");
        i = 0;
        reading = true;
    } else if (input == 0x02)
    {
      Serial.println("");
      Serial.println("STOP");
      reading = false;
      // hier LED update
      ledUpdate();
    } else {
       // Collect DATA
      if (i < rgbDataLength)
      {
        rgbData[i] = input;
        Serial.print(rgbData[i],HEX);
        Serial.print(":");
        i++;
      }
    }
    
    if (mode == 1)
    {
      timer.run();
    }
  }  
}


