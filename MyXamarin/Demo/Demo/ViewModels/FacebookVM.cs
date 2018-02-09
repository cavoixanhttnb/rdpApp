using System.Threading.Tasks;

namespace Demo.ViewModels
{
    using Helpers;
    using Models;
    using Services;

    /// <summary>
    /// Facebook view model
    /// </summary>
    public class FacebookVM : BaseVM
    {
        #region -- Methods --

        /// <summary>
        /// Initialize
        /// </summary>
        public FacebookVM()
        {
            Title = "Facebook";
        }

        /// <summary>
        /// Set profile
        /// </summary>
        /// <param name="token">accessToken</param>
        /// <returns>Return the result</returns>
        public async Task SetProfileAsync(string token)
        {
            Settings.AccessToken = token;
            Model = await FacebookService.GetProfileAsync();
        }

        #endregion

        #region -- Properties --

        /// <summary>
        /// Model
        /// </summary>
        public FacebookModel Model
        {
            get { return _model; }
            set
            {
                _model = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region -- Fields --

        /// <summary>
        /// Model
        /// </summary>
        private FacebookModel _model;

        #endregion
    }
}