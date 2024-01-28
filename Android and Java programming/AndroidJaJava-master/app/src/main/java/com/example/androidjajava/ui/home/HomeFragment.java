package com.example.androidjajava.ui.home;

import android.content.DialogInterface;
import android.content.Intent;
import android.os.Bundle;
import android.provider.Settings;
import android.util.Log;
import android.view.LayoutInflater;
import android.view.View;
import android.view.ViewGroup;
import android.widget.Button;
import android.widget.EditText;
import android.widget.TextView;
import android.widget.Toast;

import androidx.annotation.NonNull;
import androidx.fragment.app.Fragment;
import androidx.lifecycle.ViewModelProvider;

import com.example.androidjajava.AirplanemodeReceiver;
import com.example.androidjajava.DataActivity;
import com.example.androidjajava.Etsi_suomenmestarit;
import com.example.androidjajava.R;
import com.example.androidjajava.TaxiEnnustus;
import com.example.androidjajava.databinding.FragmentHomeBinding;
import com.google.android.material.dialog.MaterialAlertDialogBuilder;

public class HomeFragment extends Fragment {

    private Button buttonTest;
    private Button buttonPeli;
    private TextView textView2;
    private EditText editText;
    private Button buttonSearch;

    public static final String TAG ="MainActivity";
    private FragmentHomeBinding binding;
    public AirplanemodeReceiver airplaneRec;
    int clicks=0;


    public View onCreateView(@NonNull LayoutInflater inflater,
                             ViewGroup container, Bundle savedInstanceState) {


        HomeViewModel homeViewModel =
                new ViewModelProvider(this).get(HomeViewModel.class);

        binding = FragmentHomeBinding.inflate(inflater, container, false);
        View root = binding.getRoot();

        final TextView textView = binding.textHome;
        homeViewModel.getText().observe(getViewLifecycleOwner(), textView::setText);

        Log.e(TAG, "testotulostus");

        buttonTest=root.findViewById(R.id.buttonTest);
        buttonPeli=root.findViewById(R.id.buttonPeli);

        Button buttonTaxi=root.findViewById(R.id.button2);


        textView2=root.findViewById(R.id.textView2);

        buttonPeli.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openMinigame();
            }
        });

        buttonTaxi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openTaxi();
            }
        });


        buttonTest.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View view) {
                clicks++;
                if(textView2.getVisibility() == View.VISIBLE){
                    textView2.setVisibility(view.INVISIBLE);
                }
                else{
                    textView2.setVisibility(view.VISIBLE);
                }
                if(clicks>=5){
                    new MaterialAlertDialogBuilder(getContext())
                            .setTitle("Sää oot nyt "+clicks+" kertaa naputellu tota nappii. Alkaaks riittää pikkuhiljaa?")
                            .setPositiveButton("KYLLÄ", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialogInterface, int i) {
                                }
                            })
                            .setNegativeButton("EI", new DialogInterface.OnClickListener() {
                                @Override
                                public void onClick(DialogInterface dialogInterface, int i) {
                                }
                            })
                            .show();
                }

            }
        });

          editText=binding.simpleEditText;

          buttonSearch=binding.buttonSearch;
          buttonSearch.setOnClickListener(new View.OnClickListener() {
              @Override
              public void onClick(View view) {
                  Intent i = new Intent(getActivity(), DataActivity.class);
                  i.putExtra("Hakusana", String.valueOf(editText.getText()));
                  startActivity(i);

              }
          });



        return root;


    }

    @Override
    public void onStart() {
        super.onStart();

        boolean isAirplaneModeOn = Settings.System.getInt(getContext().getContentResolver(), Settings.Global.AIRPLANE_MODE_ON, 0) != 0; //here we check if the airplane mode is on and send a toast message according to if its on or off.

        if (isAirplaneModeOn) {
            // Airplane mode is on
            Toast.makeText(getContext(), R.string.airplaneModeOn, Toast.LENGTH_SHORT).show();

        } else {
            // Airplane mode is off
            Toast.makeText(getContext(), R.string.airplaneModeOff, Toast.LENGTH_SHORT).show();

        }
    }

    @Override
    public void onStop() {
        super.onStop();
    }

    @Override
    public void onDestroyView() {
        super.onDestroyView();
        binding = null;
    }

    public void openMinigame() {
        Intent intent=new Intent(getActivity(),Etsi_suomenmestarit.class);
        startActivity(intent);
    }

    public void openTaxi() {
        Intent intent=new Intent(getActivity(), TaxiEnnustus.class);
        startActivity(intent);
    }





}