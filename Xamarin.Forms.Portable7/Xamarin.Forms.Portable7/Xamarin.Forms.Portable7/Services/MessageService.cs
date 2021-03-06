﻿//------------------------------------------------------------------------------
// <auto-generated>
//     このコードはツールによって生成されました。
//     ランタイム バージョン:4.0.30319.42000
//
//     このファイルへの変更は、以下の状況下で不正な動作の原因になったり、
//     コードが再生成されるときに損失したりします。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by SlSvcUtil, version 5.0.61118.0
// 

using System.Runtime.Serialization;

namespace Xamarin.Forms.Portable7.Services
{
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [DataContract(Name="messageDto", Namespace="http://schemas.datacontract.org/2004/07/Xamarin.Wcf.Services")]
    public partial class messageDto : object
    {
        
        private string messageField;
        
        private string senderField;
        
        [DataMember()]
        public string message
        {
            get
            {
                return this.messageField;
            }
            set
            {
                this.messageField = value;
            }
        }
        
        [DataMember()]
        public string sender
        {
            get
            {
                return this.senderField;
            }
            set
            {
                this.senderField = value;
            }
        }
    }


    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="IMessageService")]
    public interface IMessageService
    {
    
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/IMessageService/SendMessage", ReplyAction="http://tempuri.org/IMessageService/SendMessageResponse")]
        System.IAsyncResult BeginSendMessage(messageDto message, System.AsyncCallback callback, object asyncState);
    
        void EndSendMessage(System.IAsyncResult result);
    }

    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMessageServiceChannel : IMessageService, System.ServiceModel.IClientChannel
    {
    }

    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MessageServiceClient : System.ServiceModel.ClientBase<IMessageService>, IMessageService
    {
    
        private BeginOperationDelegate onBeginSendMessageDelegate;
    
        private EndOperationDelegate onEndSendMessageDelegate;
    
        private System.Threading.SendOrPostCallback onSendMessageCompletedDelegate;
    
        private BeginOperationDelegate onBeginOpenDelegate;
    
        private EndOperationDelegate onEndOpenDelegate;
    
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
    
        private BeginOperationDelegate onBeginCloseDelegate;
    
        private EndOperationDelegate onEndCloseDelegate;
    
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
    
        public MessageServiceClient()
        {
        }
    
        public MessageServiceClient(string endpointConfigurationName) : 
            base(endpointConfigurationName)
        {
        }
    
        public MessageServiceClient(string endpointConfigurationName, string remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
        {
        }
    
        public MessageServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(endpointConfigurationName, remoteAddress)
        {
        }
    
        public MessageServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
            base(binding, remoteAddress)
        {
        }
    
        public System.Net.CookieContainer CookieContainer
        {
            get
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    return httpCookieContainerManager.CookieContainer;
                }
                else
                {
                    return null;
                }
            }
            set
            {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null))
                {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else
                {
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                                                               "ookieContainerBindingElement.");
                }
            }
        }
    
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> SendMessageCompleted;
    
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
    
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
    
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult IMessageService.BeginSendMessage(messageDto message, System.AsyncCallback callback, object asyncState)
        {
            return base.Channel.BeginSendMessage(message, callback, asyncState);
        }
    
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void IMessageService.EndSendMessage(System.IAsyncResult result)
        {
            base.Channel.EndSendMessage(result);
        }
    
        private System.IAsyncResult OnBeginSendMessage(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            messageDto message = ((messageDto)(inValues[0]));
            return ((IMessageService)(this)).BeginSendMessage(message, callback, asyncState);
        }
    
        private object[] OnEndSendMessage(System.IAsyncResult result)
        {
            ((IMessageService)(this)).EndSendMessage(result);
            return null;
        }
    
        private void OnSendMessageCompleted(object state)
        {
            if ((this.SendMessageCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.SendMessageCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
    
        public void SendMessageAsync(messageDto message)
        {
            this.SendMessageAsync(message, null);
        }
    
        public void SendMessageAsync(messageDto message, object userState)
        {
            if ((this.onBeginSendMessageDelegate == null))
            {
                this.onBeginSendMessageDelegate = new BeginOperationDelegate(this.OnBeginSendMessage);
            }
            if ((this.onEndSendMessageDelegate == null))
            {
                this.onEndSendMessageDelegate = new EndOperationDelegate(this.OnEndSendMessage);
            }
            if ((this.onSendMessageCompletedDelegate == null))
            {
                this.onSendMessageCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnSendMessageCompleted);
            }
            base.InvokeAsync(this.onBeginSendMessageDelegate, new object[] {
                message}, this.onEndSendMessageDelegate, this.onSendMessageCompletedDelegate, userState);
        }
    
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
    
        private object[] OnEndOpen(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
    
        private void OnOpenCompleted(object state)
        {
            if ((this.OpenCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
    
        public void OpenAsync()
        {
            this.OpenAsync(null);
        }
    
        public void OpenAsync(object userState)
        {
            if ((this.onBeginOpenDelegate == null))
            {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null))
            {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null))
            {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
    
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState)
        {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
    
        private object[] OnEndClose(System.IAsyncResult result)
        {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
    
        private void OnCloseCompleted(object state)
        {
            if ((this.CloseCompleted != null))
            {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
    
        public void CloseAsync()
        {
            this.CloseAsync(null);
        }
    
        public void CloseAsync(object userState)
        {
            if ((this.onBeginCloseDelegate == null))
            {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null))
            {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null))
            {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
    
        protected override IMessageService CreateChannel()
        {
            return new MessageServiceClientChannel(this);
        }
    
        private class MessageServiceClientChannel : ChannelBase<IMessageService>, IMessageService
        {
        
            public MessageServiceClientChannel(System.ServiceModel.ClientBase<IMessageService> client) : 
                base(client)
            {
            }
        
            public System.IAsyncResult BeginSendMessage(messageDto message, System.AsyncCallback callback, object asyncState)
            {
                object[] _args = new object[1];
                _args[0] = message;
                System.IAsyncResult _result = base.BeginInvoke("SendMessage", _args, callback, asyncState);
                return _result;
            }
        
            public void EndSendMessage(System.IAsyncResult result)
            {
                object[] _args = new object[0];
                base.EndInvoke("SendMessage", _args, result);
            }
        }
    }
}