namespace ExpenseTracker.api.Exceptions;

public class AttachmentNotFoundException : Exception
{
    public AttachmentNotFoundException() : base("Attachment not found.") { }

    public AttachmentNotFoundException(string message) : base(message) { }

    public AttachmentNotFoundException(string message, Exception innerException)
        : base(message, innerException) { }
}