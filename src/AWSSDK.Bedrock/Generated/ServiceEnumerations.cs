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

using Amazon.Runtime;

namespace Amazon.Bedrock
{

    /// <summary>
    /// Constants used for properties of type FineTuningJobStatus.
    /// </summary>
    public class FineTuningJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Completed = new FineTuningJobStatus("Completed");
        /// <summary>
        /// Constant Failed for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Failed = new FineTuningJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus InProgress = new FineTuningJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Stopped = new FineTuningJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for FineTuningJobStatus
        /// </summary>
        public static readonly FineTuningJobStatus Stopping = new FineTuningJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public FineTuningJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static FineTuningJobStatus FindValue(string value)
        {
            return FindValue<FineTuningJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator FineTuningJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type ModelCustomizationJobStatus.
    /// </summary>
    public class ModelCustomizationJobStatus : ConstantClass
    {

        /// <summary>
        /// Constant Completed for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Completed = new ModelCustomizationJobStatus("Completed");
        /// <summary>
        /// Constant Failed for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Failed = new ModelCustomizationJobStatus("Failed");
        /// <summary>
        /// Constant InProgress for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus InProgress = new ModelCustomizationJobStatus("InProgress");
        /// <summary>
        /// Constant Stopped for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Stopped = new ModelCustomizationJobStatus("Stopped");
        /// <summary>
        /// Constant Stopping for ModelCustomizationJobStatus
        /// </summary>
        public static readonly ModelCustomizationJobStatus Stopping = new ModelCustomizationJobStatus("Stopping");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public ModelCustomizationJobStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static ModelCustomizationJobStatus FindValue(string value)
        {
            return FindValue<ModelCustomizationJobStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator ModelCustomizationJobStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type RealTimeInferenceStatus.
    /// </summary>
    public class RealTimeInferenceStatus : ConstantClass
    {

        /// <summary>
        /// Constant ACTIVATING for RealTimeInferenceStatus
        /// </summary>
        public static readonly RealTimeInferenceStatus ACTIVATING = new RealTimeInferenceStatus("ACTIVATING");
        /// <summary>
        /// Constant ACTIVE for RealTimeInferenceStatus
        /// </summary>
        public static readonly RealTimeInferenceStatus ACTIVE = new RealTimeInferenceStatus("ACTIVE");
        /// <summary>
        /// Constant INACTIVE for RealTimeInferenceStatus
        /// </summary>
        public static readonly RealTimeInferenceStatus INACTIVE = new RealTimeInferenceStatus("INACTIVE");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public RealTimeInferenceStatus(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static RealTimeInferenceStatus FindValue(string value)
        {
            return FindValue<RealTimeInferenceStatus>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator RealTimeInferenceStatus(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortJobsBy.
    /// </summary>
    public class SortJobsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortJobsBy
        /// </summary>
        public static readonly SortJobsBy CreationTime = new SortJobsBy("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortJobsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortJobsBy FindValue(string value)
        {
            return FindValue<SortJobsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortJobsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortModelsBy.
    /// </summary>
    public class SortModelsBy : ConstantClass
    {

        /// <summary>
        /// Constant CreationTime for SortModelsBy
        /// </summary>
        public static readonly SortModelsBy CreationTime = new SortModelsBy("CreationTime");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortModelsBy(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortModelsBy FindValue(string value)
        {
            return FindValue<SortModelsBy>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortModelsBy(string value)
        {
            return FindValue(value);
        }
    }


    /// <summary>
    /// Constants used for properties of type SortOrder.
    /// </summary>
    public class SortOrder : ConstantClass
    {

        /// <summary>
        /// Constant Ascending for SortOrder
        /// </summary>
        public static readonly SortOrder Ascending = new SortOrder("Ascending");
        /// <summary>
        /// Constant Descending for SortOrder
        /// </summary>
        public static readonly SortOrder Descending = new SortOrder("Descending");

        /// <summary>
        /// This constant constructor does not need to be called if the constant
        /// you are attempting to use is already defined as a static instance of 
        /// this class.
        /// This constructor should be used to construct constants that are not
        /// defined as statics, for instance if attempting to use a feature that is
        /// newer than the current version of the SDK.
        /// </summary>
        public SortOrder(string value)
            : base(value)
        {
        }

        /// <summary>
        /// Finds the constant for the unique value.
        /// </summary>
        /// <param name="value">The unique value for the constant</param>
        /// <returns>The constant for the unique value</returns>
        public static SortOrder FindValue(string value)
        {
            return FindValue<SortOrder>(value);
        }

        /// <summary>
        /// Utility method to convert strings to the constant class.
        /// </summary>
        /// <param name="value">The string value to convert to the constant class.</param>
        /// <returns></returns>
        public static implicit operator SortOrder(string value)
        {
            return FindValue(value);
        }
    }

}