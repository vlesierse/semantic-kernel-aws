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
    /// Get Custom Model Response
    /// </summary>
    public partial class GetCustomModelResponse : AmazonWebServiceResponse
    {
        private string _baseModelArn;
        private long? _creationTime;
        private FineTuningHyperParameters _hyperParameters;
        private string _jobArn;
        private string _jobName;
        private string _modelArn;
        private string _modelName;
        private OutputDataConfig _outputDataConfig;
        private RealTimeInferenceStatus _realTimeInferenceStatus;
        private TrainingDataConfig _trainingDataConfig;
        private TrainingMetrics _trainingMetrics;
        private ValidationDataConfig _validationDataConfig;
        private List<ValidatorMetric> _validationMetrics = new List<ValidatorMetric>();

        /// <summary>
        /// Gets and sets the property BaseModelArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string BaseModelArn
        {
            get { return this._baseModelArn; }
            set { this._baseModelArn = value; }
        }

        // Check to see if BaseModelArn property is set
        internal bool IsSetBaseModelArn()
        {
            return this._baseModelArn != null;
        }

        /// <summary>
        /// Gets and sets the property CreationTime.
        /// </summary>
        [AWSProperty(Required=true)]
        public long CreationTime
        {
            get { return this._creationTime.GetValueOrDefault(); }
            set { this._creationTime = value; }
        }

        // Check to see if CreationTime property is set
        internal bool IsSetCreationTime()
        {
            return this._creationTime.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property HyperParameters.
        /// </summary>
        public FineTuningHyperParameters HyperParameters
        {
            get { return this._hyperParameters; }
            set { this._hyperParameters = value; }
        }

        // Check to see if HyperParameters property is set
        internal bool IsSetHyperParameters()
        {
            return this._hyperParameters != null;
        }

        /// <summary>
        /// Gets and sets the property JobArn.
        /// </summary>
        [AWSProperty(Required=true, Min=0, Max=1011)]
        public string JobArn
        {
            get { return this._jobArn; }
            set { this._jobArn = value; }
        }

        // Check to see if JobArn property is set
        internal bool IsSetJobArn()
        {
            return this._jobArn != null;
        }

        /// <summary>
        /// Gets and sets the property JobName.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
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
        /// Gets and sets the property ModelArn.
        /// </summary>
        [AWSProperty(Required=true, Min=20, Max=1011)]
        public string ModelArn
        {
            get { return this._modelArn; }
            set { this._modelArn = value; }
        }

        // Check to see if ModelArn property is set
        internal bool IsSetModelArn()
        {
            return this._modelArn != null;
        }

        /// <summary>
        /// Gets and sets the property ModelName.
        /// </summary>
        [AWSProperty(Required=true, Min=1, Max=63)]
        public string ModelName
        {
            get { return this._modelName; }
            set { this._modelName = value; }
        }

        // Check to see if ModelName property is set
        internal bool IsSetModelName()
        {
            return this._modelName != null;
        }

        /// <summary>
        /// Gets and sets the property OutputDataConfig.
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
        /// Gets and sets the property RealTimeInferenceStatus.
        /// </summary>
        public RealTimeInferenceStatus RealTimeInferenceStatus
        {
            get { return this._realTimeInferenceStatus; }
            set { this._realTimeInferenceStatus = value; }
        }

        // Check to see if RealTimeInferenceStatus property is set
        internal bool IsSetRealTimeInferenceStatus()
        {
            return this._realTimeInferenceStatus != null;
        }

        /// <summary>
        /// Gets and sets the property TrainingDataConfig.
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
        /// Gets and sets the property TrainingMetrics.
        /// </summary>
        public TrainingMetrics TrainingMetrics
        {
            get { return this._trainingMetrics; }
            set { this._trainingMetrics = value; }
        }

        // Check to see if TrainingMetrics property is set
        internal bool IsSetTrainingMetrics()
        {
            return this._trainingMetrics != null;
        }

        /// <summary>
        /// Gets and sets the property ValidationDataConfig.
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

        /// <summary>
        /// Gets and sets the property ValidationMetrics.
        /// </summary>
        public List<ValidatorMetric> ValidationMetrics
        {
            get { return this._validationMetrics; }
            set { this._validationMetrics = value; }
        }

        // Check to see if ValidationMetrics property is set
        internal bool IsSetValidationMetrics()
        {
            return this._validationMetrics != null && this._validationMetrics.Count > 0; 
        }

    }
}