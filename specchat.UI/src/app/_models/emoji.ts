import { Message } from "./message";
import { User } from "./user";

export interface Emoji {
    id: string;
    code: string;
    userId: string;
    user?: User;
    messageId: string;
    message?: Message;
  }
  