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
using System.Globalization;
using System.IO;
using System.Text;
using System.Xml.Serialization;

using Amazon.Bedrock.Model;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Transform;
using Amazon.Runtime.Internal.Util;
using ThirdParty.Json.LitJson;

namespace Amazon.Bedrock.Model.Internal.MarshallTransformations
{
    /// <summary>
    /// InvokeModel Request Marshaller
    /// </summary>       
    public class InvokeModelRequestMarshaller : IMarshaller<IRequest, InvokeModelRequest> , IMarshaller<IRequest,AmazonWebServiceRequest>
    {
        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="input"></param>
        /// <returns></returns>
        public IRequest Marshall(AmazonWebServiceRequest input)
        {
            return this.Marshall((InvokeModelRequest)input);
        }

        /// <summary>
        /// Marshaller the request object to the HTTP request.
        /// </summary>  
        /// <param name="publicRequest"></param>
        /// <returns></returns>
        public IRequest Marshall(InvokeModelRequest publicRequest)
        {
            IRequest request = new DefaultRequest(publicRequest, "Amazon.Bedrock");
            request.Headers["Content-Type"] = "application/json";
            request.Headers[Amazon.Util.HeaderKeys.XAmzApiVersion] = "2023-04-20";
            request.HttpMethod = "POST";

            if (!publicRequest.IsSetModelId())
                throw new AmazonBedrockException("Request object does not have required field ModelId set");
            request.AddPathResource("{modelId}", StringUtils.FromString(publicRequest.ModelId));
            request.ResourcePath = "/model/{modelId}/invoke";
            request.ContentStream =  publicRequest.Body ?? new MemoryStream();
            request.Headers[Util.HeaderKeys.ContentLengthHeader] = request.ContentStream.Length.ToString(CultureInfo.InvariantCulture);
            //request.Headers[Amazon.Util.HeaderKeys.ContentTypeHeader] = "binary/octet-stream"; 
            if (request.ContentStream != null && request.ContentStream.Length == 0)
            {
                request.Headers.Remove(Amazon.Util.HeaderKeys.ContentTypeHeader);
            }
        
            if (publicRequest.IsSetAccept()) 
            {
                request.Headers["Accept"] = publicRequest.Accept;
            }
        
            if (publicRequest.IsSetContentType()) 
            {
                request.Headers["Content-Type"] = publicRequest.ContentType;
            }

            return request;
        }
        private static InvokeModelRequestMarshaller _instance = new InvokeModelRequestMarshaller();        

        internal static InvokeModelRequestMarshaller GetInstance()
        {
            return _instance;
        }

        /// <summary>
        /// Gets the singleton.
        /// </summary>  
        public static InvokeModelRequestMarshaller Instance
        {
            get
            {
                return _instance;
            }
        }

    }
}