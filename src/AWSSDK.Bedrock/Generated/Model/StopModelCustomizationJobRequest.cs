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
    /// Container for the parameters to the StopModelCustomizationJob operation.
    /// Stop a Bedrock model customization job while in progress. This is an asynchronous
    /// operation, you need to call GetModelCustomizationJob API to get the status of model-customization
    /// job. If the job state is IN_PROGRESS the job is marked for termination and put into
    /// the STOPPING state. If the job completes before it can be stopped, it is put into
    /// the COMPLETED state; otherwise the job is stopped and put into the STOPPED state.
    /// </summary>
    public partial class StopModelCustomizationJobRequest : AmazonBedrockRequest
    {
        private string _jobIdentifier;

        /// <summary>
        /// Gets and sets the property JobIdentifier.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobIdentifier
        {
            get { return this._jobIdentifier; }
            set { this._jobIdentifier = value; }
        }

        // Check to see if JobIdentifier property is set
        internal bool IsSetJobIdentifier()
        {
            return this._jobIdentifier != null;
        }

    }
}