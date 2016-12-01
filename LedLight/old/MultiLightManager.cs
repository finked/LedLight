using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LedLight
{
    public class MultiLightManager : LedLight
    {
        public LED[] LedList;
        public byte[] RGBdata;

        public MultiLightManager()
        {
            LedList = new LED[0];
        }

        public LED[] GetLedData()
        {
            return LedList;
        }

        public LED GetLedData(int ledId)
        {
            LED foundLed = new LED();

            // Find led with ledId and return values
            for (int i = 0; i < LedList.Length; ++i)
            {
                if (LedList[i]._id == ledId)
                {
                    foundLed = LedList[i];
                }
            }

            return foundLed;
        }

        public void AddLeds(LED[] newLed)
        {
            // TODO:    With resize instead of new declaration we can remove extra LedList and save first copy command

            // Add new leds to ledlist array
            LED[] newLedList = new LED[LedList.Length + newLed.Length];
            Array.Copy(LedList, newLedList, LedList.Length);
            Array.Copy(newLed, 0, newLedList, LedList.Length, newLed.Length);

            // Replace old ledList with new one
            LedList = newLedList;
        }

        public void RemLeds(int[] LedIdSet)
        {
            // Remove leds from profile
            LED[] newLedList = new LED[LedList.Length - LedIdSet.Length];

            int index = 0;
            for (int i = 0; i < LedIdSet.Length; ++i)
            {
                if (LedIdSet[index] != LedList[i]._id)
                {
                    newLedList[i] = LedList[i + index];
                }
                else
                {
                    index++;
                }
            }

            LedList = newLedList;
        }

        // TODO:    Only change values that are set and keep old ones
        public bool SetLed(LED changeLed)
        {
            int index = -1;

            for (int i = 0; i < LedList.Length; ++i)
            {
                if (changeLed._id == LedList[i]._id)
                {
                    index = i;
                }
            }

            if (index != -1)
            {
                // Change values of LED
                LedList[index] = changeLed;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
