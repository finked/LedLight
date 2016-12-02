// Ambilight project
// Copyright 2016 Dominik Finke

#include "../include/UsbConnect.h"

UsbConnect::UsbConnect() {
    m_baudRate = 115200;
    m_dataBits = 0;
    m_portName = 0;
    // m_mode = {'8','N', '1', '0'};
}

bool UsbConnect::open() {
    printf("Opening connection");

    try {
        RS232_OpenComport(m_portName, m_baudRate, m_mode);
        printf("Connection succesful");
        return true;
    } catch (int e) {
        printf("Connection failed");
        return false;
    }
}

void UsbConnect::close() {
    printf("Closing connection");
}

void UsbConnect::sendData() {

}
