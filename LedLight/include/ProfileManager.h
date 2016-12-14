// Ambilight project
// Copyright 2016 Dominik Finke

#include <string>

class ProfileManager {

 public:
     ProfileManager();
     void loadProfile(std::string t_filename);
     void activateProfile();
};
