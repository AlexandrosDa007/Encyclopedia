using System;

namespace Encyclopedia.Model
{
    class SharedLemma
    {
        // fields
        private User sender;
        private User receiver;
        private Lemma lemma;
        private Boolean ifEditedLemma;
        private DateTime sendingDate;
        private String additionalNotes;

        // constructor
        public SharedLemma(User sender, User receiver, Lemma lemma, Char ifEditedLemmaChar, DateTime sendingDate, string additionalNotes)
        {
            if (sender.Id != receiver.Id)
            {
                this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
                this.receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            }
            else
                throw new ArgumentException("The user cannot send lemmata to himself.");

            this.lemma = lemma ?? throw new ArgumentNullException(nameof(lemma));

            if (ifEditedLemmaChar.Equals('0'))
            {
                this.ifEditedLemma = false;
            }
            else if (ifEditedLemmaChar.Equals('1'))
            {
                this.ifEditedLemma = true;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(ifEditedLemma));
            this.sendingDate = sendingDate;
            this.additionalNotes = additionalNotes ?? throw new ArgumentNullException(nameof(additionalNotes));
        }

        // constructor with null values
        public SharedLemma(User sender, User receiver, Lemma lemma, char ifEditedLemmaChar, DateTime sendingDate)
        {
            if (sender.Id != receiver.Id)
            {
                this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
                this.receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            }
            else
                throw new ArgumentException("The user cannot send lemmata to himself.");

            this.lemma = lemma ?? throw new ArgumentNullException(nameof(lemma));

            if (ifEditedLemmaChar.Equals('0'))
            {
                this.ifEditedLemma = false;
            }
            else if (ifEditedLemmaChar.Equals('1'))
            {
                this.ifEditedLemma = true;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(ifEditedLemma));
            this.sendingDate = sendingDate;

            this.additionalNotes = null;
        }

        // setters and getters
        public User Sender
        {
            get
            {
                return sender;
            }
            set
            {
                if (receiver.Id != value.Id)
                {
                    sender = value;
                }
                else
                    throw new ArgumentException("The user cannot send lemmata to himself.");
            }
        }

        public User Receiver
        {
            get
            {
                return receiver;
            }
            set
            {
                if (sender.Id != value.Id)
                {
                    receiver = value;
                }
                else
                    throw new ArgumentException("The user cannot send lemmata to himself.");
            }
        }

        public Lemma Lemma
        {
            get
            {
                return lemma;
            }
            set
            {
                lemma = value;
            }
        }

        public Boolean IfEditedLemma
        {
            get
            {
                return ifEditedLemma;
            }
            set
            {
                ifEditedLemma = value;
            }
        }

        public DateTime SendingDate
        {
            get
            {
                return sendingDate;
            }
            set
            {
                sendingDate = value;
            }
        }

        public String AdditionalNotes
        {
            get
            {
                return additionalNotes;
            }
            set
            {
                additionalNotes = value;
            }
        }

        // overrided ToString
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
