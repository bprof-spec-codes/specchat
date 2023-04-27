import { Chat } from "./chat";

export class Message {
    id?: number;
    content = "";
    Time = "";
    IsPinned?: boolean;
    
    userId = "";
    //public virtual ApplicationUser User { get; set; }

    chatId = "";
    chat?: Chat;
    
    MainMessageId = "";
    //MainMessage: Message;
    //public virtual Message? MainMessage { get; set; }
    
    //public virtual ICollection<Message>? SubMessage { get; set; }
    //public virtual ICollection<Emoji>? Emojis { get; set; }

}