using System;

namespace Encyclopedia.Model
{
    /// <summary>
    /// Represents the data in the database.
    /// </summary>
    public class SharedLemma
    {
        #region Private variables
        private User sender;
        private User receiver;
        private Lemma lemma;
        private Boolean ifEditedLemma;
        private DateTime sendingDate;
        private String additionalNotes;
        #endregion

        #region Constructors
        public SharedLemma(User sender, User receiver, Lemma lemma, Char ifEditedLemmaChar, DateTime sendingDate, string additionalNotes)
        {
            if (sender.Id != receiver.Id)
            {
                this.sender = sender ?? throw new ArgumentNullException(nameof(sender));
                this.receiver = receiver ?? throw new ArgumentNullException(nameof(receiver));
            }
            else
                throw new ArgumentException("The user cannot send lemmata to himself.");

            Lemma = lemma;

            if (ifEditedLemmaChar.Equals('0'))
            {
                IfEditedLemma = false;
            }
            else if (ifEditedLemmaChar.Equals('1'))
            {
                IfEditedLemma = true;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(ifEditedLemma));
            SendingDate = sendingDate;
            AdditionalNotes = additionalNotes ?? throw new ArgumentNullException(nameof(additionalNotes));
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

            Lemma = lemma;

            if (ifEditedLemmaChar.Equals('0'))
            {
                IfEditedLemma = false;
            }
            else if (ifEditedLemmaChar.Equals('1'))
            {
                IfEditedLemma = true;
            }
            else
                throw new ArgumentOutOfRangeException(nameof(ifEditedLemma));
            SendingDate = sendingDate;

            this.additionalNotes = null;
        }
        #endregion

        #region Properties
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
                lemma = value ?? throw new ArgumentNullException(nameof(lemma));
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
				if (value.Length <= 250)
				{
					additionalNotes = value;
				}
				else
					throw new ArgumentOutOfRangeException(nameof(additionalNotes));
            }
        }
        #endregion

        /// <summary>
        /// Overrides the ToString method.
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return base.ToString();
        }
    }
}
