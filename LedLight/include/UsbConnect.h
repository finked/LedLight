// Ambilight project
// Copyright 2016 Dominik Finke

#include "rs232.h"
#include <string>

class UsbConnect {
 private:
     int m_baudRate;
     int m_dataBits;
     int m_portName;
     const char* m_mode;

 public:
     UsbConnect();
     UsbConnect(int, int, int);
     bool open();
     void close();
     void send(unsigned char *, int);
};
