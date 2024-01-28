package com.example.androidjajava;

import android.content.Intent;
import android.os.Bundle;
import android.view.View;
import android.view.animation.Animation;
import android.view.animation.AnimationUtils;
import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

import java.util.Random;

public class Etsi_suomenmestarit extends AppCompatActivity {


    int pisteet=0;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_etsi_suomenmestarit);

         ImageView kanadaMalja1=findViewById(R.id.imageView8);
         ImageView kanadaMalja2=findViewById(R.id.imageView7);
         ImageView kanadaMalja3=findViewById(R.id.imageView6);
         ImageView kanadaMalja4=findViewById(R.id.imageView9);

         TextView peliTeksti=findViewById(R.id.textViewPeli);
         TextView palauteTeksti=findViewById(R.id.textViewPalaute);
         Button buttonUUdestaan=findViewById(R.id.buttonUudestaan);
         Button buttonTakaisin=findViewById(R.id.buttonTakaisin);
         TextView muuttuja=findViewById(R.id.textView3);
         TextView yrityksetTeksti=findViewById(R.id.pisteet);

         buttonUUdestaan.setVisibility(View.INVISIBLE);
         palauteTeksti.setVisibility(View.INVISIBLE);

        muuttuja.setText(String.valueOf(pisteet));





        // create instance of Random class
        Random rand = new Random();

        // Generate random integers in range 0 to 4
        int randomNumber = rand.nextInt(3);

        //onClick function that starts the animation when picture is clicked
        kanadaMalja1.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation hyperspaceJumpAnimation = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.anim);

                kanadaMalja1.startAnimation(hyperspaceJumpAnimation);

                pisteet=pisteet+1;
                muuttuja.setText(String.valueOf(pisteet));


                if (randomNumber==0){
                    kanadaMalja1.setImageResource(R.drawable.ilvesjuhlat);
                    kanadaMalja2.setVisibility(View.INVISIBLE);
                    kanadaMalja3.setVisibility(View.INVISIBLE);
                    kanadaMalja4.setVisibility(View.INVISIBLE);

                    yrityksetTeksti.setVisibility(View.INVISIBLE);
                    muuttuja.setVisibility(View.INVISIBLE);
                    peliTeksti.setVisibility(View.INVISIBLE);
                    palauteTeksti.setVisibility(View.VISIBLE);
                    buttonUUdestaan.setVisibility(View.VISIBLE);
                }
                else{
                    kanadaMalja1.setVisibility(View.INVISIBLE);
                }
            }
        });

        kanadaMalja2.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation hyperspaceJumpAnimation = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.anim);

                kanadaMalja2.startAnimation(hyperspaceJumpAnimation);

                pisteet=pisteet+1;
                muuttuja.setText(String.valueOf(pisteet));



                if (randomNumber==1){
                    kanadaMalja2.setImageResource(R.drawable.ilvesjuhlat);
                    kanadaMalja1.setVisibility(View.INVISIBLE);
                    kanadaMalja3.setVisibility(View.INVISIBLE);
                    kanadaMalja4.setVisibility(View.INVISIBLE);

                    yrityksetTeksti.setVisibility(View.INVISIBLE);
                    muuttuja.setVisibility(View.INVISIBLE);
                    peliTeksti.setVisibility(View.INVISIBLE);
                    palauteTeksti.setVisibility(View.VISIBLE);
                    buttonUUdestaan.setVisibility(View.VISIBLE);

                }
                else{
                    kanadaMalja2.setVisibility(View.INVISIBLE);

                }
            }
        });

       kanadaMalja3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation hyperspaceJumpAnimation = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.anim);

                kanadaMalja3.startAnimation(hyperspaceJumpAnimation);

                pisteet=pisteet+1;
                muuttuja.setText(String.valueOf(pisteet));


                if (randomNumber==2){
                    kanadaMalja3.setImageResource(R.drawable.ilvesjuhlat);
                    kanadaMalja2.setVisibility(View.INVISIBLE);
                    kanadaMalja1.setVisibility(View.INVISIBLE);
                    kanadaMalja4.setVisibility(View.INVISIBLE);

                    yrityksetTeksti.setVisibility(View.INVISIBLE);
                    muuttuja.setVisibility(View.INVISIBLE);
                    peliTeksti.setVisibility(View.INVISIBLE);
                    palauteTeksti.setVisibility(View.VISIBLE);
                    buttonUUdestaan.setVisibility(View.VISIBLE);

                }
                else{
                    kanadaMalja3.setVisibility(View.INVISIBLE);

                }
            }
        });

        kanadaMalja4.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Animation hyperspaceJumpAnimation = AnimationUtils.loadAnimation(getApplicationContext(), R.anim.anim);

                kanadaMalja4.startAnimation(hyperspaceJumpAnimation);

                pisteet=pisteet+1;
                muuttuja.setText(String.valueOf(pisteet));


                if (randomNumber==3){
                    kanadaMalja4.setImageResource(R.drawable.ilvesjuhlat);
                    kanadaMalja3.setVisibility(View.INVISIBLE);
                    kanadaMalja2.setVisibility(View.INVISIBLE);
                    kanadaMalja1.setVisibility(View.INVISIBLE);

                    yrityksetTeksti.setVisibility(View.INVISIBLE);
                    muuttuja.setVisibility(View.INVISIBLE);
                    peliTeksti.setVisibility(View.INVISIBLE);
                    palauteTeksti.setVisibility(View.VISIBLE);
                    buttonUUdestaan.setVisibility(View.VISIBLE);

                }
                else{
                    kanadaMalja4.setVisibility(View.INVISIBLE);


                }
            }
        });

        //onclick function that starts the activity again
        buttonUUdestaan.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                Intent intent = getIntent();
                finish();
                startActivity(intent);
            }
        });

        buttonTakaisin.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                toFrontPage();
            }
        });
    }

    public void toFrontPage() {
        finish();
        Intent intent=new Intent(this, BottomNavigation.class);
        startActivity(intent);
    }
}