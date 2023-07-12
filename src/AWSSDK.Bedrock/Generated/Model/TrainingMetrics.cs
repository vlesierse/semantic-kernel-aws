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
    /// <Undocumented>
    /// </summary>
    public partial class TrainingMetrics
    {
        private float? _trainingLoss;

        /// <summary>
        /// Gets and sets the property TrainingLoss.
        /// </summary>
        public float TrainingLoss
        {
            get { return this._trainingLoss.GetValueOrDefault(); }
            set { this._trainingLoss = value; }
        }

        // Check to see if TrainingLoss property is set
        internal bool IsSetTrainingLoss()
        {
            return this._trainingLoss.HasValue; 
        }

    }
}