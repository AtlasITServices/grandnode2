﻿using Grand.Business.System.Utilities;
using System.Collections.Generic;

namespace Grand.Business.System.Interfaces.Installation
{
    /// <summary>
    /// Translation service for installation process
    /// </summary>
    public partial interface IInstallationLocalizedService
    {
        /// <summary>
        /// Get locale resource value
        /// </summary>
        /// <param name="resourceName">Resource name</param>
        /// <returns>Resource value</returns>
        string GetResource(string resourceName);

        /// <summary>
        /// Get current language for the installation page
        /// </summary>
        /// <returns>Current language</returns>
        InstallationLanguage GetCurrentLanguage();

        /// <summary>
        /// Save a language for the installation page
        /// </summary>
        /// <param name="languageCode">Language code</param>
        void SaveCurrentLanguage(string languageCode);

        /// <summary>
        /// Get a list of available languages
        /// </summary>
        /// <returns>Available installation languages</returns>
        IList<InstallationLanguage> GetAvailableLanguages();

        /// <summary>
        /// Get a list of available collactions
        /// </summary>
        /// <returns>Available collations mongodb</returns>
        IList<InstallationCollation> GetAvailableCollations();
    }
}
