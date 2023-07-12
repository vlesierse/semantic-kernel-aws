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
    public partial class ValidatorMetric
    {
        private float? _validationLoss;
        private string _validatorName;

        /// <summary>
        /// Gets and sets the property ValidationLoss.
        /// </summary>
        public float ValidationLoss
        {
            get { return this._validationLoss.GetValueOrDefault(); }
            set { this._validationLoss = value; }
        }

        // Check to see if ValidationLoss property is set
        internal bool IsSetValidationLoss()
        {
            return this._validationLoss.HasValue; 
        }

        /// <summary>
        /// Gets and sets the property ValidatorName.
        /// </summary>
        [AWSProperty(Min=1, Max=63)]
        public string ValidatorName
        {
            get { return this._validatorName; }
            set { this._validatorName = value; }
        }

        // Check to see if ValidatorName property is set
        internal bool IsSetValidatorName()
        {
            return this._validatorName != null;
        }

    }
}