using System;

namespace EdlinSoftware.Safe.SafeLib
{
	/// <summary>
	/// Class for searching text in topics.
	/// </summary>
	public static class Searcher
	{
		private static TopicsList m_LastTopics;
		private static Topic m_LastFoundTopic;

        /// <summary>
		/// Last text to search.
		/// </summary>
		public static string LastText { get; private set; }

		/// <summary>
		/// Returns first found topic with given text.
		/// </summary>
		/// <param name="topics">List of topics.</param>
		/// <param name="text">Text to find.</param>
		/// <returns>Topic with given text; false, otherwise.</returns>
		/// <exception cref="ArgumentNullException">Topics list is null or text to search is null or empty.</exception>
		public static Topic Search(TopicsList topics, string text)
		{
			Topic foundTopic = InternalSearch(topics, text);

			m_LastTopics = topics;
			LastText = text;
			m_LastFoundTopic = foundTopic;

			return foundTopic;
		}

		/// <summary>
		/// Finds next topic with text from Search method.
		/// </summary>
		/// <returns>Next topic with text from Search method.</returns>
		/// <exception cref="InvalidOperationException">Search method is not called.</exception>
		public static Topic SearchNext()
		{
			Topic foundTopic = InternalSearchNext(m_LastTopics, LastText);

			m_LastFoundTopic = foundTopic;

			return foundTopic;
		}

		/// <summary>
		/// Returns first found topic with given text.
		/// </summary>
		/// <param name="topics">List of topics.</param>
		/// <param name="text">Text to find.</param>
		/// <returns>Topic with given text; false, otherwise.</returns>
		/// <exception cref="ArgumentNullException">Topics list is null or text to search is null or empty.</exception>
		private static Topic InternalSearch(TopicsList topics, string text)
		{
			if (topics == null)
				throw new ArgumentNullException("topics");
			if (string.IsNullOrEmpty(text))
				throw new ArgumentNullException("text");

			foreach (Topic topic in topics)
			{
				if (topic.Name.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1)
					return topic;
				if (topic.Description.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1)
					return topic;

				foreach (IDataField field in topic.Fields)
				{
					if (field.ContainsText(text))
						return topic;
				}

				Topic subtopic = InternalSearch(topic.SubTopics, text);
				if (subtopic != null)
					return subtopic;
			}

			return null;
		}

		/// <summary>
		/// Returns next topic with given text.
		/// </summary>
		/// <param name="topics">List of topics.</param>
		/// <param name="text">Text to find.</param>
		/// <returns>Topic with given text; false, otherwise.</returns>
		/// <exception cref="ArgumentNullException">Topics list is null or text to search is null or empty.</exception>
		private static Topic InternalSearchNext(TopicsList topics, string text)
		{
			if (topics == null)
				throw new ArgumentNullException("topics");
			if (string.IsNullOrEmpty(text))
				throw new ArgumentNullException("text");

			foreach (Topic topic in topics)
			{
				if (topic.Name.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1)
				{
					if (m_LastFoundTopic == null)
					{ return topic; }
					else
					{
						if (m_LastFoundTopic == topic)
						{ 
							m_LastFoundTopic = null;
						}
					}
				}
				else if (topic.Description.IndexOf(text, StringComparison.CurrentCultureIgnoreCase) != -1)
				{
					if (m_LastFoundTopic == null)
					{ return topic; }
					else
					{
						if (m_LastFoundTopic == topic)
						{
							m_LastFoundTopic = null;
						}
					}
				}
				else foreach (IDataField field in topic.Fields)
				{
					if (field.ContainsText(text))
					{
						if (m_LastFoundTopic == null)
						{ return topic; }
						else
						{
							if (m_LastFoundTopic == topic)
							{
								m_LastFoundTopic = null;
							}
						}
						break;
					}
				}

				Topic subtopic = InternalSearchNext(topic.SubTopics, text);
				if (subtopic != null)
					return subtopic;
			}

			return null;
		}
	}
}
