using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;

namespace MIS.Foundation.Framework.Queues
{
    /// <summary>
    /// Ӧ��֪ͨ�¼�������
    /// </summary>
    [Serializable]
    public class NotifyEventArgs : EventArgs
    {
        /// <summary>
        /// ���⡣
        /// </summary>
        public string Topic
        {
            get;
            internal set;
        }
        /// <summary>
        /// ��Ϣ��
        /// </summary>
        public object Message
        {
            get;
            internal set;
        }
        /// <summary>
        /// ��ʼ��NotifyEnentArgs�¼�������
        /// </summary>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public NotifyEventArgs()
        {

        }
        /// <summary>
        /// ��ʼ��NotifyEnentArgs�¼�������
        /// </summary>
        /// <param name="topic">���⡣</param>
        /// <param name="message">��Ϣ��</param>
        [MethodImpl(MethodImplOptions.NoInlining)]
        public NotifyEventArgs(string topic, object message)
        {
            this.Topic = topic;
            this.Message = message;
        }
    }
}
