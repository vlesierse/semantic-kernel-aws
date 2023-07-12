/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
 * 
 * Licensed under the Apache License, Version 2.0 (the "License").
 * You may not use this file except in compliance with the License.
 * A copy of the License is located at
 * 
 *  http://aws.amazon.com/apache2.0
 * 
 * or in the "license" file accompanying this file. This file is distributed
 * on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either
 * express or implied. See the License for the specific language governing
 * permissions and limitations under the License.
 */

/*
 * Do not modify this file. This file is generated from the bedrock-2023-04-20.normal.json service model.
 */
using System;
using System.Collections.Generic;
using System.Xml.Serialization;
using System.Text;
using System.IO;
using System.Net;

using Amazon.Runtime;
using Amazon.Runtime.Internal;

namespace Amazon.Bedrock.Model
{
    /// <summary>
    /// List Custom Models Response
    /// </summary>
    public partial class ListCustomModelsResponse : AmazonWebServiceResponse
    {
        private List<CustomModelSummary> _modelSummaries = new List<CustomModelSummary>();
        private string _nextToken;

        /// <summary>
        /// Gets and sets the property ModelSummaries.
        /// </summary>
        public List<CustomModelSummary> ModelSummaries
        {
            get { return this._modelSummaries; }
            set { this._modelSummaries = value; }
        }

        // Check to see if ModelSummaries property is set
        internal bool IsSetModelSummaries()
        {
            return this._modelSummaries != null && this._modelSummaries.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property NextToken.
        /// </summary>
        [AWSProperty(Min=1, Max=2048)]
        public string NextToken
        {
            get { return this._nextToken; }
            set { this._nextToken = value; }
        }

        // Check to see if NextToken property is set
        internal bool IsSetNextToken()
        {
            return this._nextToken != null;
        }

    }
}