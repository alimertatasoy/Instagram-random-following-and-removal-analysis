using InstagramApiSharp;
using InstagramApiSharp.API;
using InstagramApiSharp.API.Builder;
using InstagramApiSharp.Classes;
using InstagramApiSharp.Classes.Models;
using System.Linq;
namespace instagram
{
    public partial class Form1 : Form
    {
        private UserSessionData _userSessionData;
        private IInstaApi _instaApi;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            _userSessionData = new UserSessionData
            {
                UserName = txtUsername.Text,
                Password = txtPassword.Text
            };

            _instaApi = InstaApiBuilder.CreateBuilder()
                .SetUser(_userSessionData)
                .Build();

            if (!_instaApi.IsUserAuthenticated)
            {
                var loginResult = await _instaApi.LoginAsync();
                if (loginResult.Succeeded)
                {
                    MessageBox.Show("Giriþ Baþarýlý!");
                }
                else
                {
                    MessageBox.Show("Giriþ Baþarýsýz!");
                }
            }
        }

        private async void btnGetAnalytics_Click(object sender, EventArgs e)
        {
            if (_instaApi != null && _instaApi.IsUserAuthenticated)
            {
                var userInfo = await _instaApi.UserProcessor.GetUserInfoByUsernameAsync(txtUsername.Text);
                var followerCount = userInfo.Value.FollowerCount;
                var followingCount = userInfo.Value.FollowingCount;
                var mediaCount = userInfo.Value.MediaCount;

                label8.Text = $"{followerCount}";
                label9.Text = $"{followingCount}";
                label10.Text = $"{mediaCount}";
            }
            else
            {
                MessageBox.Show("Lütfen önce giriþ yapýn.");
            }
        }

        private async void btnFollowTenUsers_Click(object sender, EventArgs e)
        {
            if (_instaApi != null && _instaApi.IsUserAuthenticated)
            {
                var followersResult = await _instaApi.UserProcessor.GetUserFollowersAsync(txtUsername.Text, PaginationParameters.MaxPagesToLoad(1));
                var followers = followersResult.Value;
                if (followers?.Count > 10)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        var userId = followers[i].Pk;
                        await _instaApi.UserProcessor.FollowUserAsync(userId);
                    }

                    MessageBox.Show("Baþarýyla 10 kullanýcýyý takip ettiniz.");
                }
                else
                {
                    MessageBox.Show("Takipçi sayýsý yetersiz.");
                }
            }
            else
            {
                MessageBox.Show("Lütfen önce giriþ yapýn.");
            }
        }

        private async void btnUnfollowNonFollowers_Click(object sender, EventArgs e)
        {
            if (_instaApi != null && _instaApi.IsUserAuthenticated)
            {
                var followersResult = await _instaApi.UserProcessor.GetUserFollowersAsync(txtUsername.Text, PaginationParameters.MaxPagesToLoad(1));
                var followingResult = await _instaApi.UserProcessor.GetUserFollowingAsync(txtUsername.Text, PaginationParameters.MaxPagesToLoad(1));

                var followers = followersResult.Value;
                var following = followingResult.Value;

                var nonFollowers = following.Where(f => !followers.Any(ff => ff.Pk == f.Pk)).Take(10).ToList();

                foreach (var user in nonFollowers)
                {
                    await _instaApi.UserProcessor.UnFollowUserAsync(user.Pk);
                }

                MessageBox.Show("Baþarýyla takipten çýkan kullanýcýlar.");
            }
            else
            {
                MessageBox.Show("Lütfen önce giriþ yapýn.");
            }
        }
    }
}