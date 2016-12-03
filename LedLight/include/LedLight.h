#include <string>
#include "../include/UsbConnect.h"

class LedLight {
 private:
     int m_numLeds;
     char m_color[3];
     UsbConnect m_usb;

 public:
     LedLight();
     void startProfile();
     void stopProfile();
     void sendData();
     void createProfile(std::string t_filename);
     void loadProfile(std::string t_filename);
};
