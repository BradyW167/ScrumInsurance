using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Org.BouncyCastle.Bcpg.OpenPgp;
using Org.BouncyCastle.Utilities;

namespace ScrumInsurance
{
    public class Message
    {
        public long ID { get; set; }
        public string SenderID { get; set; }
        public string SenderUsername {  get; set; }
        public string RecipientID { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public Message(Row row)
        {
            if (row.Columns.TryGetValue("messages.id", out var id)) ID = Convert.ToInt64(id);
            if (row.Columns.TryGetValue("sender_id", out var sender)) SenderID = sender.ToString();
            if (row.Columns.TryGetValue("username", out var username)) SenderUsername = username.ToString();
            if (row.Columns.TryGetValue("recipient_id", out var recipient)) RecipientID = recipient.ToString();
            if (row.Columns.TryGetValue("subject", out var subject)) Subject = subject.ToString();
            if (row.Columns.TryGetValue("content", out var content)) Content = content.ToString();
            if (row.Columns.TryGetValue("date", out var date)) Date = date.ToString();
        }

        public override string ToString()
        {
            return $"ID: {ID}, Subject: {Subject}, Sender: {SenderUsername}, Recipient: {Recipient}, Date: {Date}, Content: {Content}";
        }
    }
}
