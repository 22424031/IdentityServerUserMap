﻿namespace UserLoginBE.Models
{
    public class UserValidateResponse
    {
        public string UserName { get; set; }
        public string Role { get; set; }
        public string AccessToken { get; set; }
        public int ExpiresIn { get; set; }
    }
}
