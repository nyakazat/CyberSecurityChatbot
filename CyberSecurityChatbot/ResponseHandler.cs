namespace CyberSecurityChatbot
{
    public static class ResponseHandler
    {
        public static string GetResponse(string input)
        {
            if (input.Contains("how are you"))
                return "I'm just a program, but I'm functioning perfectly and ready to help you stay safe online!";

            if (input.Contains("purpose") || input.Contains("what do you do"))
                return "My purpose is to educate South African citizens about cybersecurity threats and how to avoid them.";

            if (input.Contains("password"))
                return "Use strong passwords with at least 12 characters, including uppercase and lowercase letters, numbers, and symbols. Avoid using personal information and consider using a password manager.";

            if (input.Contains("phishing"))
                return "Phishing scams attempt to trick you into revealing personal or financial information. Always verify the sender's email address and avoid clicking on suspicious links or attachments.";

            if (input.Contains("safe browsing") || input.Contains("browsing"))
                return "To browse safely, ensure websites use HTTPS, avoid downloading files from unknown sources, keep your browser updated, and use reputable antivirus software.";

            if (input.Contains("malware"))
                return "Malware is malicious software designed to harm your device or steal information. Install antivirus software and avoid downloading files from untrusted sources.";

            if (input.Contains("social engineering"))
                return "Social engineering involves manipulating individuals into revealing confidential information. Always verify identities before sharing sensitive data.";

            return "I didn't quite understand that. Could you rephrase or ask about passwords, phishing, or safe browsing?";
        }
    }
}