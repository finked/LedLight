// Ambilight project
// Copyright 2016 Dominik Finke

#include "../include/UsbConnect.h"

UsbConnect::UsbConnect() {
    m_baudRate = 115200;
    m_dataBits = 0;
    m_portName = 0;
    // m_mode = {'8','N', '1', '0'};
}

UsbConnect::UsbConnect(int t_baudRate, int t_dataBits, int t_portName) {
    m_baudRate = t_baudRate;
    m_dataBits = t_dataBits;
    m_portName = t_portName;
}

bool UsbConnect::open() {
    printf("Opening connection\n");

    try {
        RS232_OpenComport(m_portName, m_baudRate, m_mode);
        printf("Connection succesful\n");
        return true;
    } catch (int e) {
        printf("Connection failed\n");
        return false;
    }
}

void UsbConnect::close() {
    try {
        RS232_CloseComport(m_portName);
        printf("Connection closed\n");
    } catch (int e) {
        printf("Closing connection failed\n");
    }
}

void UsbConnect::send(unsigned char * t_buffer, int t_size) {
    printf("Sending data ... ");
    RS232_SendBuf(m_portName, t_buffer, t_size);
    printf("done\n");
}
