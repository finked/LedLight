// Ambilight project
// Copyright 2016 Dominik Finke

#include "../include/UsbConnect.h"
#include "../include/ProfileManager.h"

int main() {
    // Create test connection to arduino bord
    UsbConnect test(115200, 0, 3);

    // Open port
    test.open();

    // Send testdata
    // TODO(DF): Fill buffer
    unsigned char * buf;
    test.send(buf, 10);

    // Later structure
    // Load profile
    ProfileManager pm;
    pm.loadProfile("./profile/monoTest.xml");
    pm.activateProfile();
}
