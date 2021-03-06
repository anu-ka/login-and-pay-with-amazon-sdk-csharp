/******************************************************************************* 
 *  Copyright 2008-2013 Amazon.com, Inc. or its affiliates. All Rights Reserved.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Off Amazon Payments Service CSharp Library
 *  API Version: 2013-01-01
 * 
 */
 
using System;
using System.Collections.Generic;
using System.Text;
using OffAmazonPaymentsService;
using OffAmazonPaymentsService.Mock;
using OffAmazonPaymentsService.Model;

namespace OffAmazonPaymentsServiceSampleLibrary
{
    public class OffAmazonPaymentsServiceCancellation
    {
        /************************************************************************
         * Order Cancellation Example
         * This example demonstrates how to cancel an order.
         * Before cancelling an order, the order must be confirmed and cannot be associated with any captured authorizations.
         * 
         * This example will show the following service calls:
         *    - CancelOrderReference
        ***********************************************************************/
        private static IOffAmazonPaymentsService service;
        private static OffAmazonPaymentsServicePropertyCollection propertiesCollection;

        public OffAmazonPaymentsServiceCancellation()
        {
            /************************************************************************
            * Instantiate the Merchant propertiesCollection object which contains required parameters for creating a Marketplace Payment Service  
            ***********************************************************************/
            propertiesCollection = OffAmazonPaymentsServicePropertyCollection.getInstance();

            /************************************************************************
            * Instantiate  Implementation of Marketplace Payment Service  
            ***********************************************************************/
            service = new OffAmazonPaymentsServiceClient(propertiesCollection);
        }

        //Invoke the CancelOrderReference method
        public CancelOrderReferenceResponse CancelOrderReference(string orderReferenceId)
        {
            CancelOrderReferenceRequest request = new CancelOrderReferenceRequest();
            request.SellerId = propertiesCollection.MerchantID;
            request.AmazonOrderReferenceId = orderReferenceId;

            return CancelOrderReferenceSample.InvokeCancelOrderReference(service, request);
        }
    }
}

