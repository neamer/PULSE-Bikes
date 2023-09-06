using Flurl.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PULSE.Model;
using PULSE.WinUI.Properties;

namespace PULSE.WinUI.Helpers
{
    public class APIService
    {
        private string _resource = null;
        public static string _endpoint = "http://localhost:5000/";//Settings.Default.ApiURL;

        public static string Username = null;
        public static string Password = null;

        public APIService(string resource)
        {
            _resource = resource;
        }

        public async Task<T> GetCustomPath<T>(string resource, object search = null)
        {
            try
            {
                var query = "";
                if (search != null)
                {
                    query = await search.ToQueryString();
                }

                var list = await $"{_endpoint}{_resource}/{resource}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> PostCustomPath<T>(string resource, object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> PutCustomPath<T>(string resource, object id, object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> Get<T>(object search = null)
        {
            try
            {
                var query = "";
                if (search != null)
                {
                    query = await search.ToQueryString();
                }

                var list = await $"{_endpoint}{_resource}?{query}".WithBasicAuth(Username, Password).GetJsonAsync<T>();

                return list;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> GetById<T>(object id)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).GetJsonAsync<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> Post<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PostJsonAsync(request).ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }

        }

        public async Task<T> Put<T>(object id, object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> Delete<T>(object id)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{id}".WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> DeleteCustomPath<T>(string resource, object id)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}/{resource}/{id}".WithBasicAuth(Username, Password).DeleteAsync().ReceiveJson<T>();
                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }

        public async Task<T> PutComposite<T>(object request)
        {
            try
            {
                var result = await $"{_endpoint}{_resource}".WithBasicAuth(Username, Password).PutJsonAsync(request).ReceiveJson<T>();

                return result;
            }
            catch (FlurlHttpException ex)
            {
                var responseMsg = ex.Call.HttpResponseMessage.ReasonPhrase;

                MessageBox.Show(responseMsg, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return default;
            }
        }
    }
}
