﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Net;
using System.IO;

namespace POS.COMMON
{
    public class SMS 
    {
        private WebRequest request;
	    private Stream dataStream;

        private string status, defaultUrl;

        public string DefaultUrl
        {
            get { return defaultUrl; }
            set { defaultUrl = value; }
        }
	 
	    public String Status
	    {
	        get
	         {
	              return status;
	         }
	        set
	         {
	            status = value;
	         }
        }
        public SMS() { this.DefaultUrl = "http://corpsms.banglalinkgsm.com/smscorp/direct/sendSMS.php?username=nexttel&passw=nexttel&msisdn="; }
        //public SMS(string url)
        //{
        //        // Create a request using a URL that can receive a post.
	 
        //     request = WebRequest.Create(url);
        //}

        // public SMS( string method) 
        // {
 
        //  if (method.Equals("GET") || method.Equals("POST"))
        //  {
        //     // Set the Method property of the request to POST.
        //    request.Method = method;
        //  }
        //  else
        //  {
        //       throw new Exception("Invalid Method Type");
        //  }
        //}

        // public SMS(string url, string method, string data)
        //            : this(url, method)
        //{

        //    // Create POST data and convert it to a byte array.
        //    string postData = data;
        //    byte[] byteArray = Encoding.UTF8.GetBytes(postData);

        //    // Set the ContentType property of the WebRequest.
        //    request.ContentType = "application/x-www-form-urlencoded";

        //    // Set the ContentLength property of the WebRequest.
        //    request.ContentLength = byteArray.Length;

        //    // Get the request stream.
        //    dataStream = request.GetRequestStream();

        //    // Write the data to the request stream.
        //    dataStream.Write(byteArray, 0, byteArray.Length);

        //    // Close the Stream object.
        //    dataStream.Close();
	 
        // }
	 
         public string GetResponse(string url)
	     {
             request = WebRequest.Create(url);
             request.Method = "GET";
            // Get the original response.
            WebResponse response = request.GetResponse();

            this.Status = ((HttpWebResponse)response).StatusDescription;

            // Get the stream containing all content returned by the requested server.
            dataStream = response.GetResponseStream();

            // Open the stream using a StreamReader for easy access.
            StreamReader reader = new StreamReader(dataStream);

            // Read the content fully up to the end.
            string responseFromServer = reader.ReadToEnd();

            // Clean up the streams.
            reader.Close();
            dataStream.Close();
            response.Close();

            return responseFromServer;
	   }

    }

}
