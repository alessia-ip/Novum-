﻿//-----------------------------------------------------------------------
// <copyright file="AugmentedImageVisualizer.cs" company="Google">
//
// Copyright 2018 Google Inc. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
// http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
//
// </copyright>
//-----------------------------------------------------------------------

namespace GoogleARCore.Examples.AugmentedImage
{
    using System;
    using System.Collections.Generic;
    using System.Runtime.InteropServices;
    using GoogleARCore;
    using GoogleARCoreInternal;
    using UnityEngine;
    using UnityEngine.Video;



    public class AugmentedImageVisualizer : MonoBehaviour
    {
        /// <summary>
        /// The AugmentedImage to visualize.
        /// </summary>
        public AugmentedImage Image;

        /// <summary>
        /// A model for the lower left corner of the frame to place when an image is detected.
        /// </summary>
        public GameObject empty;
        public GameObject video;
        public GameObject one;
        public GameObject two;
        public GameObject three;
        public GameObject four;
        public GameObject five;


       
        public void Start()
        {
            empty.SetActive(false);
            video.SetActive(false);
            one.SetActive(false);
            two.SetActive(false);
            three.SetActive(false);
            four.SetActive(false);
            five.SetActive(false);

        }

        public void Update()
        {

            if (Image == null || Image.TrackingState != TrackingState.Tracking)
            {
                empty.SetActive(false);
                one.SetActive(false);
                two.SetActive(false);
                three.SetActive(false);
                four.SetActive(false);
                five.SetActive(false);

                //video.SetActive(false);
                return;
            }
            if (Image.Name == "Intro")
            {
                video.SetActive(true);
                return;

            }
            if (Image.Name == "HandheldOne")
            {
                one.SetActive(true);
                return;

            }
            if (Image.Name == "HandheldTwo")
            {
                two.SetActive(true);
                return;

            }
            if (Image.Name == "HandheldThree")
            {
                three.SetActive(true);
                return;

            }
            if (Image.Name == "HandheldFour")
            {
                four.SetActive(true);
                return;
            }
            if (Image.Name == "AmbientMarker")
            {
                five.SetActive(true);
                return;
            }
        }
    }
}