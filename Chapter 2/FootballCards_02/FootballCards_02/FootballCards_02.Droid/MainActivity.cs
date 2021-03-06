﻿
using Android.App;
using Android.OS;
using GalaSoft.MvvmLight.Helpers;
using GalaSoft.MvvmLight.Views;

namespace FootballCards_02.Droid
{
	[Activity(Label = "FootballCards_02.Droid", MainLauncher = true, Icon = "@drawable/icon")]
	public partial class MainActivity : ActivityBase
	{
		public MainViewModel ViewModel => App.Locator.Main;

		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);

			SetContentView(Resource.Layout.Main);

			CreateTextViewBindings();

			CreateEditTextBinding();

			CreateButtonBinding();
		}

		void CreateTextViewBindings()
		{
			this.SetBinding(
			() => ViewModel.TeamName,
			() => TxtTeamName.Text,
			BindingMode.TwoWay);

			this.SetBinding(
				() => ViewModel.StadiumName,
				() => TxtStadium.Text,
				BindingMode.TwoWay);

			this.SetBinding(
			() => ViewModel.Capacity,
			() => TxtCapacity.Text,
			BindingMode.TwoWay);
		}

		void CreateEditTextBinding()
		{
			this.SetBinding(
			() => ViewModel.TextNumberOfShuffles,
			() => EditShuffles.Text,
			BindingMode.TwoWay);
		}

		void CreateButtonBinding()
		{
			BtnShuffle.SetCommand(
			Events.Click,
			ViewModel.ButtonClicked);
		}
	}
}


