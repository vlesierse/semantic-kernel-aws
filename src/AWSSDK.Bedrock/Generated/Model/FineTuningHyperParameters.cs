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
    public partial class FineTuningHyperParameters
    {
        private int? _batchSize;
        private int? _epochCount;
        private LearningRateConfig _learningRateConfig;

        /// <summary>
        /// Gets and sets the property BatchSize.
        /// </summary>
        [AWSProperty(Min=1, Max=64)]
        public int BatchSize
        {
            get { return this._batchSize.GetValueOrDefault(); }
            set { this._batchSize = value; }
        }

        // Check to see if BatchSize property is set
        internal bool IsSetBatchSize()
        {
            return this._batchSize.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property EpochCount.
        /// </summary>
        [AWSProperty(Min=1, Max=50)]
        public int EpochCount
        {
            get { return this._epochCount.GetValueOrDefault(); }
            set { this._epochCount = value; }
        }

        // Check to see if EpochCount property is set
        internal bool IsSetEpochCount()
        {
            return this._epochCount.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property LearningRateConfig.
        /// </summary>
        public LearningRateConfig LearningRateConfig
        {
            get { return this._learningRateConfig; }
            set { this._learningRateConfig = value; }
        }

        // Check to see if LearningRateConfig property is set
        internal bool IsSetLearningRateConfig()
        {
            return this._learningRateConfig != null;
        }

    }
}