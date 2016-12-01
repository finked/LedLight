// Ambilight project
// Copyright 2016 Dominik Finke

#include "rs232.h"
#include <string>

class UsbConnect {
 private:
     int baudRate;
     int dataBits;
     std::string portName;

 public:
     UsbConnect();
     void open();
     void close();
     void sendData();
};
