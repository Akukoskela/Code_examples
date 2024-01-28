package com.example.androidjajava.ui.notifications;

import android.media.Ringtone;
import android.media.RingtoneManager;
import android.net.Uri;
import android.os.Bundle;
import android.os.CountDownTimer;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.NumberPicker;
import android.widget.TextView;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.example.androidjajava.R;
import com.example.androidjajava.databinding.FragmentNotificationsBinding;
import com.google.android.material.button.MaterialButtonToggleGroup;

import java.util.concurrent.TimeUnit;

public class NotificationsFragment extends Fragment {

    private FragmentNotificationsBinding binding;

    public static final String TAG ="NotificationFragment";
    CountDownTimer timer;
    Ringtone song;
    int millisekunnit;
    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {
        NotificationsViewModel notificationsViewModel =
                new ViewModelProvider(this).get(NotificationsViewModel.class);

        binding = FragmentNotificationsBinding.inflate(inflater, container, false);
        View root = binding.getRoot();

       // final TextView textView = binding.textNotifications;
        //notificationsViewModel.getText().observe(getViewLifecycleOwner(), textView::setText);

        //lets bind elements from activity class so we can use them here in Java
        NumberPicker numPickerSec = binding.numbPickerSec;
        NumberPicker numbPickerMin=binding.numbPickerMin;

        MaterialButtonToggleGroup buttonToggleGroup=binding.toggleButton;

        numPickerSec.setMaxValue(60);
        numPickerSec.setMinValue(0);

        numbPickerMin.setMaxValue(60);
        numbPickerMin.setMinValue(0);

        TextView aikaText=binding.aikaTextView;
        aikaText.setVisibility(View.INVISIBLE);

        Animation hyperspaceJumpAnimation = AnimationUtils.loadAnimation(getContext(),R.anim.anim); //here we declare variable which contains animation that we use when te timer is up

        Uri currentRintoneUri = RingtoneManager.getActualDefaultRingtoneUri(getActivity().getApplicationContext(), RingtoneManager.TYPE_RINGTONE);  //lets get the current ringtone from users phone, so we can play it when the timer is up.
        song= RingtoneManager.getRingtone(getActivity(), currentRintoneUri);

        numPickerSec.setOnValueChangedListener(new NumberPicker.OnValueChangeListener() {
            @Override
            public void onValueChange(NumberPicker numberPicker, int i, int i1) {   //program sets value to 'aikaText' TextView according to user input.
                 aikaText.setText(String.valueOf(numberPicker.getValue()+(numbPickerMin.getValue()*60)));
                 millisekunnit=numberPicker.getValue()+(numbPickerMin.getValue()*60);
            }
        });

        numbPickerMin.setOnValueChangedListener(new NumberPicker.OnValueChangeListener() {
            @Override
            public void onValueChange(NumberPicker numberPicker, int i, int i1) { //program sets value to 'aikaText' TextView according to user input.
                aikaText.setText(String.valueOf(60*numberPicker.getValue()+numPickerSec.getValue()));
                millisekunnit=60*numberPicker.getValue()+numPickerSec.getValue();
            }
        });
        buttonToggleGroup.addOnButtonCheckedListener(  //lets add onclick listener to the buttons
                new MaterialButtonToggleGroup.OnButtonCheckedListener() {
                    @Override
                    public void onButtonChecked(MaterialButtonToggleGroup group, int checkedId, boolean isChecked) {


                        if (isChecked) {
                            if (checkedId == binding.startButton.getId()) { // if button named 'start' is pressed, the system starts a countdown using user input. The countdown is done with 'CountDownTimer' class.

                                aikaText.setVisibility(View.VISIBLE);  //If user presses 'start' button, the value of seconds comes to visible.
                             timer= new CountDownTimer(millisekunnit*1000+1000, 1000) { //lets put the right values to parameters. CountDownTimer works with milliseconds so that's why the value needs to be multiplied by 1000.

                                    public void onTick(long millisUntilFinished) {  //'onTick()' function runs when countdown is running. Here we set the running value(mins and secs) to the 'aikaText'.
                                        aikaText.setText(""+String.format("%d min, %d sec",
                                                TimeUnit.MILLISECONDS.toMinutes( millisUntilFinished),
                                                TimeUnit.MILLISECONDS.toSeconds(millisUntilFinished) -
                                                        TimeUnit.MINUTES.toSeconds(TimeUnit.MILLISECONDS.toMinutes(millisUntilFinished))));
                                        millisekunnit=millisekunnit-1;
                                    }
                                    public void onFinish() { //function 'onFinish()' runs when countdown ends.
                                        aikaText.setText(R.string.timerStopText);

                                        song.play(); //here we use 'play()' function to get the ringtone to play.

                                        aikaText.startAnimation(hyperspaceJumpAnimation); //here we use 'hyperspaceJumpAnimation' when the timer is up.
                                    }
                                }.start();

                            } else if (checkedId == binding.pauseButton.getId()) { //if pause button is pressed, the countdown stops but it can be resumed at the same value where it was paused. Also if song is playing, it stops.
                                if (timer!=null){
                                    timer.cancel();
                                    song.stop();
                                }

                            } else if (checkedId == binding.stopButton.getId()) { //if stop button is pressed, the countdown stops and the value goes invisible to the user. Also if song is playing, it stops.
                                if (timer!=null){
                                    timer.cancel();
                                    aikaText.setVisibility(View.INVISIBLE);
                                    aikaText.setText(String.valueOf(0));
                                    song.stop();
                                }
                            }
                        }
                    }
                });

        String[] sekunnit=new String[61]; //Lets make an array which allow us to show 's' after every second instead of only the number.
        for (int i =0;i< sekunnit.length;i++){
            sekunnit[i]=i+" s";
        }
        numPickerSec.setDisplayedValues(sekunnit); //here we set the values to the 'NumberPicker' element.

        String[] minuutit=new String[61];  //Lets make an array which allow us to show 'min' after every second instead of only the number.
        for (int i =0;i< minuutit.length;i++){
            minuutit[i]=i+" min";
        }
        numbPickerMin.setDisplayedValues(minuutit); //here we set the values to the 'NumberPicker' element.
        return root;
    }
    @Override
    public void onDestroyView() {
        super.onDestroyView();
        binding = null;
    }
}