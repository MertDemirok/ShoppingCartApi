using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using Newtonsoft.Json;
using ShoppingCart.Project.Models;

namespace ShoppingCart.Project.Utilities
{
    public class UtilitiyService
    {
        private static ExternalService _externalService;

        public T ReadJsonData<T>(string name)
        {
            
            using (StreamReader r = new StreamReader(name))
            {
                string json = r.ReadToEnd();
                return  JsonConvert.DeserializeObject<T>(json);
            }
        }

        public string Encrypt(string toEncrypt, bool useHashing)
        {
            byte[] keyArray;
            byte[] toEncryptArray = UTF8Encoding.UTF8.GetBytes(toEncrypt);

            // Configuration.GetSection("AppConfiguration")["SecurityKey"];
            // Get the key from config file

            string key = "carthashkey001";
           //(string)settingsReader.GetValue("SecurityKey",typeof(String));
            
            //If hashing use get hashcode regards to your key
            if (useHashing)
            {
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //Always release the resources and flush data
                // of the Cryptographic service provide. Best Practice

                hashmd5.Clear();
            }
            else
                keyArray = UTF8Encoding.UTF8.GetBytes(key);

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes.
            //We choose ECB(Electronic code Book)
            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)

            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateEncryptor();
            //transform the specified region of bytes array to resultArray
            byte[] resultArray =
              cTransform.TransformFinalBlock(toEncryptArray, 0,
              toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor
            tdes.Clear();
            //Return the encrypted data into unreadable string format
            return Convert.ToBase64String(resultArray, 0, resultArray.Length);
        }

        public string Decrypt(string cipherString, bool useHashing)
        {
           
            byte[] keyArray;
            //get the byte code of the string

            byte[] toEncryptArray = Convert.FromBase64String(cipherString);

            // Configuration.GetSection("AppConfiguration")["SecurityKey"];
            // Get the key from config file

            string key = "carthashkey001";
            //(string)settingsReader.GetValue("SecurityKey",typeof(String));

            if (useHashing)
            {
                //if hashing was used get the hash code with regards to your key
                MD5CryptoServiceProvider hashmd5 = new MD5CryptoServiceProvider();
                keyArray = hashmd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(key));
                //release any resource held by the MD5CryptoServiceProvider

                hashmd5.Clear();
            }
            else
            {
                //if hashing was not implemented get the byte code of the key
                keyArray = UTF8Encoding.UTF8.GetBytes(key);
            }

            TripleDESCryptoServiceProvider tdes = new TripleDESCryptoServiceProvider();
            //set the secret key for the tripleDES algorithm
            tdes.Key = keyArray;
            //mode of operation. there are other 4 modes. 
            //We choose ECB(Electronic code Book)

            tdes.Mode = CipherMode.ECB;
            //padding mode(if any extra byte added)
            tdes.Padding = PaddingMode.PKCS7;

            ICryptoTransform cTransform = tdes.CreateDecryptor();
            byte[] resultArray = cTransform.TransformFinalBlock(
                                 toEncryptArray, 0, toEncryptArray.Length);
            //Release resources held by TripleDes Encryptor                
            tdes.Clear();
            //return the Clear decrypted TEXT
            return UTF8Encoding.UTF8.GetString(resultArray);
        }

        public List<Value> GetTrendyolSubCategoryList(string name)
        {
            _externalService = new ExternalService();


            //TODO: parameter will be dynamic
            var response = _externalService.BasicJsonRequest<TrendData>
                ("https://api.trendyol.com", "/websearchgw/api/aggregations/" + fixedText(name));

            List<Value> category = new List<Value>();
            foreach (var item in response.Result.Aggregations)
            {
                if (item.Group == "CATEGORY")
                {
                    category = item.Values;

                }
            }

            return category;
        }

        public string fixedText(string text)
        {
            var retval = "";

            //kadin+ayakkabi"
            if (!text.Contains("+"))
            {
                retval = text.Replace(" ", "+");
            }
            return retval;
        }

    }
}
