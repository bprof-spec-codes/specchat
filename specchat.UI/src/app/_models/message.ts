import { Chat } from "./chat";
import { Emoji } from "./emoji";
import { User } from "./user";

export class Message {
    id: string = "";
    content: string = "";
    time: Date = new Date();
    isPinned?: boolean;
    userId: string = "";
    chatId: string = "";
    mainMessageId?: string | null;
    chat?: Chat;
    mainMessage?: Message | null;
    subMessage?: Message[] | null;
    emojis?: Emoji[] | null;
    user?: User;
  }
  