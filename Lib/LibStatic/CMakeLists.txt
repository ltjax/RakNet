cmake_minimum_required(VERSION 2.6)
project(RakNetLibStatic)

FILE(GLOB ALL_HEADER_SRCS ${RakNet_SOURCE_DIR}/Source/*.h)
FILE(GLOB ALL_CPP_SRCS ${RakNet_SOURCE_DIR}/Source/*.cpp)

include_directories( ${RAKNET_INTERNAL_INCLUDE_DIRS} ) 

add_library(RakNetLibStatic STATIC ${ALL_CPP_SRCS} ${ALL_HEADER_SRCS} readme.txt)

IF(WIN32 AND NOT UNIX)
	SET( CMAKE_CXX_FLAGS "${CMAKE_CXX_FLAGS} /D WIN32 /D _RAKNET_LIB /D _CRT_NONSTDC_NO_DEPRECATE /D _CRT_SECURE_NO_DEPRECATE /GS- /GR- ")
ENDIF(WIN32 AND NOT UNIX)

IF(WIN32 AND NOT UNIX)
	target_link_libraries (RakNetLibStatic ${RAKNET_LIBRARY_LIBS})

	IF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")

		IF( MSVC10 OR MSVC11 OR MSVC12 OR MSVC14 )
			set_target_properties(RakNetLibStatic PROPERTIES STATIC_LIBRARY_FLAGS "/NODEFAULTLIB:\"LIBCD.lib LIBCMTD.lib MSVCRT.lib\"" )
		ELSE()
			set_target_properties(RakNetLibStatic PROPERTIES STATIC_LIBRARY_FLAGS "/NODEFAULTLIB:&quot;LIBCD.lib LIBCMTD.lib MSVCRT.lib&quot;" )
		ENDIF()
				
	ENDIF(NOT ${CMAKE_GENERATOR} STREQUAL "MSYS Makefiles")

else()
	target_link_libraries (RakNetLibStatic ${RAKNET_LIBRARY_LIBS})
endif()

install(TARGETS RakNetLibStatic 
  ARCHIVE DESTINATION lib
)
