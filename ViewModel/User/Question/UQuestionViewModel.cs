﻿using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Ioc;
using GalaSoft.MvvmLight.Messaging;
using TrustworthyCompanion.Model;

namespace TrustworthyCompanion.ViewModel.User.Question {
	public class UQuestionViewModel : ViewModelBase {
		/// <summary>
		/// Initializes a new instance of the UQuestionViewModel class.
		/// </summary>
		public UQuestionViewModel() {
			// Register the messenger
			// Subscribe the messenger for messages sent to it
			if(!SimpleIoc.Default.IsRegistered<QuestionModel>()) {
				Messenger.Default.Register<QuestionModel>(this, (action) => SetupProperties(action));
			}
		}

		#region RELAY COMMANDS
		#endregion

		#region PROPERTIES
		/// <summary>
		/// The Question property
		/// </summary>
		private QuestionModel _question;
		public QuestionModel Question {
			get { return _question; }
			set { Set(() => this.Question, ref _question, value); }
		}
		#endregion

		private void SetupProperties(QuestionModel action) {
			Question = action;
		}
	}
}
