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
    /// This exception is thrown when a request fails in the model container
    /// </summary>
    #if !NETSTANDARD
    [Serializable]
    #endif
    public partial class ModelStreamErrorException : AmazonBedrockException
    {
        private string _originalMessage;
        private int? _originalStatusCode;

        /// <summary>
        /// Constructs a new ModelStreamErrorException with the specified error
        /// message.
        /// </summary>
        /// <param name="message">
        /// Describes the error encountered.
        /// </param>
        public ModelStreamErrorException(string message) 
            : base(message) {}

        /// <summary>
        /// Construct instance of ModelStreamErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        public ModelStreamErrorException(string message, Exception innerException) 
            : base(message, innerException) {}

        /// <summary>
        /// Construct instance of ModelStreamErrorException
        /// </summary>
        /// <param name="innerException"></param>
        public ModelStreamErrorException(Exception innerException) 
            : base(innerException) {}

        /// <summary>
        /// Construct instance of ModelStreamErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="innerException"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ModelStreamErrorException(string message, Exception innerException, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, innerException, errorType, errorCode, requestId, statusCode) {}

        /// <summary>
        /// Construct instance of ModelStreamErrorException
        /// </summary>
        /// <param name="message"></param>
        /// <param name="errorType"></param>
        /// <param name="errorCode"></param>
        /// <param name="requestId"></param>
        /// <param name="statusCode"></param>
        public ModelStreamErrorException(string message, ErrorType errorType, string errorCode, string requestId, HttpStatusCode statusCode) 
            : base(message, errorType, errorCode, requestId, statusCode) {}


#if !NETSTANDARD
        /// <summary>
        /// Constructs a new instance of the ModelStreamErrorException class with serialized data.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is null. </exception>
        /// <exception cref="T:System.Runtime.Serialization.SerializationException">The class name is null or <see cref="P:System.Exception.HResult" /> is zero (0). </exception>
        protected ModelStreamErrorException(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
            : base(info, context)
        {
            this.OriginalMessage = (string)info.GetValue("OriginalMessage", typeof(string));
            this.OriginalStatusCode = (int)info.GetValue("OriginalStatusCode", typeof(int));
        }

        /// <summary>
        /// Sets the <see cref="T:System.Runtime.Serialization.SerializationInfo" /> with information about the exception.
        /// </summary>
        /// <param name="info">The <see cref="T:System.Runtime.Serialization.SerializationInfo" /> that holds the serialized object data about the exception being thrown.</param>
        /// <param name="context">The <see cref="T:System.Runtime.Serialization.StreamingContext" /> that contains contextual information about the source or destination.</param>
        /// <exception cref="T:System.ArgumentNullException">The <paramref name="info" /> parameter is a null reference (Nothing in Visual Basic). </exception>
#if BCL35
        [System.Security.Permissions.SecurityPermission(
            System.Security.Permissions.SecurityAction.LinkDemand,
            Flags = System.Security.Permissions.SecurityPermissionFlag.SerializationFormatter)]
#endif
        [System.Security.SecurityCritical]
        // These FxCop rules are giving false-positives for this method
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2123:OverrideLinkDemandsShouldBeIdenticalToBase")]
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Security", "CA2134:MethodsMustOverrideWithConsistentTransparencyFxCopRule")]
        public override void GetObjectData(System.Runtime.Serialization.SerializationInfo info, System.Runtime.Serialization.StreamingContext context)
        {
            base.GetObjectData(info, context);
            info.AddValue("OriginalMessage", this.OriginalMessage);
            info.AddValue("OriginalStatusCode", this.OriginalStatusCode);
        }
#endif

        /// <summary>
        /// Gets and sets the property OriginalMessage.
        /// </summary>
        public string OriginalMessage
        {
            get { return this._originalMessage; }
            set { this._originalMessage = value; }
        }

        // Check to see if OriginalMessage property is set
        internal bool IsSetOriginalMessage()
        {
            return this._originalMessage != null;
        }

        /// <summary>
        /// Gets and sets the property OriginalStatusCode.
        /// </summary>
        [AWSProperty(Min=100, Max=599)]
        public int OriginalStatusCode
        {
            get { return this._originalStatusCode.GetValueOrDefault(); }
            set { this._originalStatusCode = value; }
        }

        // Check to see if OriginalStatusCode property is set
        internal bool IsSetOriginalStatusCode()
        {
            return this._originalStatusCode.HasValue; 
        }

    }
}