using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EmailSend
{
    public class CookiesActions
    {
        private const int DAYS_TO_SAVE = 14;
        private readonly HttpRequest _request;

        public CookiesActions(HttpRequest request)
        {
            _request = request;
        }

        public string GetCookie(string name)
        {
            string result = string.Empty;

            if (_request.Cookies[name] != null)
            {
                result = _request.Cookies[name].Value;
            }
            if (result == null)
            {
                return string.Empty;
            }

            return result;
        }

        public HttpCookie CreateCookie(string name, string value, int saveDays = DAYS_TO_SAVE)
        {
            HttpCookie cookie = new HttpCookie(name)
            {
                Expires = DateTime.UtcNow.AddDays(saveDays),
                Value = value
            };

            return cookie;
        }

        public bool CheckIfExists(string name)
        {
            return new HttpCookie(name) != null;
        }

    }
}