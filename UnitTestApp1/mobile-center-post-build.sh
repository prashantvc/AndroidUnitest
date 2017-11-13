#!/usr/bin/env bash

echo "Inside post build script"

ls -al $MOBILECENTER_OUTPUT_DIRECTORY

msbuild /t:SignAndroidPackage /t:RunMyTests /v:d