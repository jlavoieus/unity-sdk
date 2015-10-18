﻿/**
* Copyright 2015 IBM Corp. All Rights Reserved.
*
* Licensed under the Apache License, Version 2.0 (the "License");
* you may not use this file except in compliance with the License.
* You may obtain a copy of the License at
*
*      http://www.apache.org/licenses/LICENSE-2.0
*
* Unless required by applicable law or agreed to in writing, software
* distributed under the License is distributed on an "AS IS" BASIS,
* WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
* See the License for the specific language governing permissions and
* limitations under the License.
*
* @author Richard Lyle (rolyle@us.ibm.com)
*/

using System;
using System.Text;

namespace IBM.Watson.Utilities
{
    /// <summary>
    /// Helper class for holding a user & password, used by both the WSCOnnector & RESTConnector.
    /// </summary>
    public class Credentials
    {
        public Credentials()
        { }
        public Credentials( string user, string password )
        {
            User = user;
            Password = password;
        }

        public string User { get; set; }
        public string Password { get; set; }

        public string CreateAuthorization()
        {
            return "Basic " + Convert.ToBase64String(Encoding.ASCII.GetBytes(User + ":" + Password));
        }
    };
}