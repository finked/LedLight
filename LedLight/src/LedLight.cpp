// Ambilight project
// Copyright 2016 Dominik Finke

#include "../include/LedLight.h"

LedLight::LedLight() {
    m_numLeds = 0;
}

void LedLight::startProfile() {
    m_usb.open();
}

void LedLight::stopProfile() {
}

void LedLight::createProfile(std::string t_filename) {
}

void LedLight::loadProfile(std::string t_filename) {

}
