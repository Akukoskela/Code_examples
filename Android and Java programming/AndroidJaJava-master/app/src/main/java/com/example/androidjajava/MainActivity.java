package com.example.androidjajava;

import android.content.Intent;
import android.content.IntentFilter;
import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class MainActivity extends AppCompatActivity {

    private Button buttonTest;
    private Button buttonPeli;
    private TextView textView2;
    public static final String TAG ="MainActivity";
    public AirplanemodeReceiver airplaneRec;
    public IntentFilter intentFilter;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        Log.e(TAG, "testotulostus");

        buttonTest=findViewById(R.id.buttonTest);
        buttonPeli=findViewById(R.id.buttonPeli);
        Button buttonTaxi=findViewById(R.id.button2);

        textView2=findViewById(R.id.textView2);

        buttonTaxi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openTaxi();
            }
        });

        buttonPeli.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                openMinigame();
            }
        });

        buttonTest.setOnClickListener(new View.OnClickListener() {
            @Override

            public void onClick(View view) {
                if(textView2.getVisibility() == View.VISIBLE){
                    textView2.setVisibility(view.INVISIBLE);
                }
                else{
                    textView2.setVisibility(view.VISIBLE);
                }
            }
        });
    }

    public void openMinigame() {
        Intent intent=new Intent(this,Etsi_suomenmestarit.class);
        startActivity(intent);
    }

    public void openTaxi() {
        Intent intent=new Intent(this,TaxiEnnustus.class);
        startActivity(intent);
    }

    @Override
    protected void onStart() {
        super.onStart();

        intentFilter.addAction("com.example.myapp.AirplaneMode");
        registerReceiver(airplaneRec,intentFilter);


    }

    @Override
    protected void onStop() {
        super.onStop();

        unregisterReceiver(airplaneRec);
    }

    
}