﻿using MakoIoT.Device.Platform.LocalConfig.Controllers;
using MakoIoT.Device.Services.Server;

namespace MakoIoT.Device.Platform.LocalConfig.Extensions
{
    public static class WebServerOptionsExtension
    {
        /// <summary>
        /// Registers configuration website controllers.
        /// </summary>
        /// <param name="options"></param>
        public static void AddConfigurationWebsite(this WebServerOptions options)
        {
            options.AddController(typeof(IndexController));
            options.AddController(typeof(ExitController));
            options.AddController(typeof(StaticFileController));
        }
    }
}
