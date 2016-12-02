#include <string>

class LedLight {
 private:
     int m_numLeds;
     char m_color[3];
 public:
     LedLight();
     void startProfile();
     void stopProfile();
     void sendData();
     void createProfile(std::string t_filename);
     void loadProfile(std::string t_filename);
};
