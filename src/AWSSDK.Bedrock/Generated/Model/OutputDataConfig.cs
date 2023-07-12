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
    /// Specifies the Amazon S3 path where you want Bedrock to store the results of your model
    /// customization job
    /// </summary>
    public partial class OutputDataConfig
    {
        private string _s3Uri;

        /// <summary>
        /// Gets and sets the property S3Uri. 
        /// <para>
        /// Output files structure in the Customer's S3 folder - training_job_id/
        /// </para>
        ///  <ul> <li>training_artifacts <ul> <li>step_wise_training_metrics.csv</li> </ul> </li>
        /// <li>validation_artifacts <ul> <li>post_training_validation <ul> <li>validation_metrics.csv</li>
        /// </ul> </li> </ul> </li> </ul> 
        /// <para>
        /// Output files format and structure
        /// </para>
        ///  <ol> <li> 
        /// <para>
        /// step_wise_training_metrics.csv step_number,epoch_number,training_loss 1,1,0.2 2,1,0.18
        /// ...
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// validation_metrics.csv step_number,epoch_number,validation_loss 1, 1, 0.12 2, 1, 0.09
        /// 3, 2, 0.06 .....
        /// </para>
        ///  </li> </ol>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=1024)]
        public string S3Uri
        {
            get { return this._s3Uri; }
            set { this._s3Uri = value; }
        }

        // Check to see if S3Uri property is set
        internal bool IsSetS3Uri()
        {
            return this._s3Uri != null;
        }

    }
}