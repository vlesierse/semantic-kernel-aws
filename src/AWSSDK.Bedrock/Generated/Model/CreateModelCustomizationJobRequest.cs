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
    /// Container for the parameters to the CreateModelCustomizationJob operation.
    /// Create a job to model customize Bedrock foundation models or customized models with
    /// your custom training data.
    /// </summary>
    public partial class CreateModelCustomizationJobRequest : AmazonBedrockRequest
    {
        private string _baseModelIdentifier;
        private string _clientRequestToken;
        private string _customModelName;
        private List<Tag> _customModelTags = new List<Tag>();
        private Dictionary<string, string> _hyperParameters = new Dictionary<string, string>();
        private string _jobName;
        private List<Tag> _jobTags = new List<Tag>();
        private OutputDataConfig _outputDataConfig;
        private string _roleArn;
        private TrainingDataConfig _trainingDataConfig;
        private ValidationDataConfig _validationDataConfig;

        /// <summary>
        /// Gets and sets the property BaseModelIdentifier. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=2048)]
        public string BaseModelIdentifier
        {
            get { return this._baseModelIdentifier; }
            set { this._baseModelIdentifier = value; }
        }

        // Check to see if BaseModelIdentifier property is set
        internal bool IsSetBaseModelIdentifier()
        {
            return this._baseModelIdentifier != null;
        }

        /// <summary>
        /// Gets and sets the property ClientRequestToken. <Undocumented>
        /// </summary>
        [AWSProperty(Min=1, Max=256)]
        public string ClientRequestToken
        {
            get { return this._clientRequestToken; }
            set { this._clientRequestToken = value; }
        }

        // Check to see if ClientRequestToken property is set
        internal bool IsSetClientRequestToken()
        {
            return this._clientRequestToken != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelName. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string CustomModelName
        {
            get { return this._customModelName; }
            set { this._customModelName = value; }
        }

        // Check to see if CustomModelName property is set
        internal bool IsSetCustomModelName()
        {
            return this._customModelName != null;
        }

        /// <summary>
        /// Gets and sets the property CustomModelTags. <Undocumented>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> CustomModelTags
        {
            get { return this._customModelTags; }
            set { this._customModelTags = value; }
        }

        // Check to see if CustomModelTags property is set
        internal bool IsSetCustomModelTags()
        {
            return this._customModelTags != null && this._customModelTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property HyperParameters. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true)]
        public Dictionary<string, string> HyperParameters
        {
            get { return this._hyperParameters; }
            set { this._hyperParameters = value; }
        }

        // Check to see if HyperParameters property is set
        internal bool IsSetHyperParameters()
        {
            return this._hyperParameters != null && this._hyperParameters.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property JobName. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string JobName
        {
            get { return this._jobName; }
            set { this._jobName = value; }
        }

        // Check to see if JobName property is set
        internal bool IsSetJobName()
        {
            return this._jobName != null;
        }

        /// <summary>
        /// Gets and sets the property JobTags. <Undocumented>
        /// </summary>
        [AWSProperty(Min=0, Max=200)]
        public List<Tag> JobTags
        {
            get { return this._jobTags; }
            set { this._jobTags = value; }
        }

        // Check to see if JobTags property is set
        internal bool IsSetJobTags()
        {
            return this._jobTags != null && this._jobTags.Count > 0; 
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true)]
        public OutputDataConfig OutputDataConfig
        {
            get { return this._outputDataConfig; }
            set { this._outputDataConfig = value; }
        }

        // Check to see if OutputDataConfig property is set
        internal bool IsSetOutputDataConfig()
        {
            return this._outputDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property RoleArn. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=2048)]
        public string RoleArn
        {
            get { return this._roleArn; }
            set { this._roleArn = value; }
        }

        // Check to see if RoleArn property is set
        internal bool IsSetRoleArn()
        {
            return this._roleArn != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataConfig. <Undocumented>
        /// </summary>
        [AWSProperty(Required=true)]
        public TrainingDataConfig TrainingDataConfig
        {
            get { return this._trainingDataConfig; }
            set { this._trainingDataConfig = value; }
        }

        // Check to see if TrainingDataConfig property is set
        internal bool IsSetTrainingDataConfig()
        {
            return this._trainingDataConfig != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDataConfig. <Undocumented>
        /// </summary>
        public ValidationDataConfig ValidationDataConfig
        {
            get { return this._validationDataConfig; }
            set { this._validationDataConfig = value; }
        }

        // Check to see if ValidationDataConfig property is set
        internal bool IsSetValidationDataConfig()
        {
            return this._validationDataConfig != null;
        }

    }
}