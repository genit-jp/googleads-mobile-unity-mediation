// Copyright 2017 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//      http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using System.Reflection;
using UnityEngine;

namespace GoogleMobileAds.Mediation.AppLovin.Common
{
    public class DummyClient : IAppLovinClient
    {
        public DummyClient()
        {
            Debug.Log("Dummy " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetHasUserConsent(bool hasUserConsent)
        {
            Debug.Log("Dummy " + MethodBase.GetCurrentMethod().Name);
        }

        public void SetDoNotSell(bool doNotSell)
        {
            Debug.Log("Dummy " + MethodBase.GetCurrentMethod().Name);
        }
    }
}
