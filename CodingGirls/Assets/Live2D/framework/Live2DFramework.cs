/**
 *
 *  You can modify and use this source freely
 *  only for the development of application related Live2D.
 *
 *  (c) Live2D Inc. All rights reserved.
 */
using System.Collections;
using System.Collections.Generic;
using live2d;

namespace live2d.framework
{
    public class Live2DFramework
    {
        private static IPlatformManager platformManager;

        public static IPlatformManager getPlatformManager()
        {
            return platformManager;
        }

        public static void setPlatformManager(IPlatformManager platformManager)
        {
            Live2DFramework.platformManager = platformManager;
        }


    }
}