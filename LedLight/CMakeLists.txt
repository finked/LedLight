cmake_minimum_required(VERSION 2.8)

project( LedLight )
include_directories(
"${PROJECT_SOURCE_DIR}/src"
"${PROJECT_SOURCE_DIR}/include"
)

set(EXECUTABLE_OUTPUT_PATH ${PROJECT_BINARY_DIR}/../bin/)
add_definitions (
-O3
-std=c++11
)

add_executable( ledLight 
src/main.cpp 
src/UsbConnect.cpp
src/rs232.c
src/LedLight.cpp
)
