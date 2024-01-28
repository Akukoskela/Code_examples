package com.example.androidjajava;

import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.NumberPicker;
import android.widget.Switch;
import android.widget.TextView;

import androidx.appcompat.app.AppCompatActivity;

public class TaxiEnnustus extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_taxi_ennustus);

        NumberPicker numberPickerKM=findViewById(R.id.numbPickerKM);
        NumberPicker numberPickerLKM=findViewById(R.id.numbPickerMatkustajaLKM);

        TextView hintaSarake=findViewById(R.id.hintaSarake);

        Switch switchPyhäpäivä=findViewById(R.id.switchPyhäpäivä);

        Button buttonArvioi=findViewById(R.id.buttonArvioi);

        numberPickerKM.setMaxValue(500); //lisätään mahdolliset kilometrimäärät
        numberPickerKM.setMinValue(0);

        numberPickerLKM.setMaxValue(8); //lisätään mahdolliset matkustajamäärät
        numberPickerLKM.setMinValue(0);


        buttonArvioi.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View view) {
                int km=numberPickerKM.getValue();
                int matkustajaMäärä=numberPickerLKM.getValue();

                double aloitusMaksuPyhänä=7.50;
                double aloitusmaksuArkisin=4.50;

                double matkaTaksaAlle5=1.90;
                double matkaTaksa5TaiYli=2.50;

                double lopullinenHinta;

                if(switchPyhäpäivä.isChecked()){

                    if(matkustajaMäärä>4){
                        lopullinenHinta= km*matkaTaksa5TaiYli+aloitusMaksuPyhänä;
                        hintaSarake.setText(String.valueOf(lopullinenHinta));

                    } else if (matkustajaMäärä<=4) {
                        lopullinenHinta=km*matkaTaksaAlle5+aloitusMaksuPyhänä;
                        hintaSarake.setText(String.valueOf(lopullinenHinta));
                    }

                }
                else {
                    if(matkustajaMäärä>4){
                        lopullinenHinta= km*matkaTaksa5TaiYli+aloitusmaksuArkisin;
                        hintaSarake.setText(String.valueOf(lopullinenHinta));

                    } else if (matkustajaMäärä<=4) {
                        lopullinenHinta=km*matkaTaksaAlle5+aloitusmaksuArkisin;
                        hintaSarake.setText(String.valueOf(lopullinenHinta));
                    }
                }
            }
        });
    }
}