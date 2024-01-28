package com.example.androidjajava;

import android.os.Bundle;
import android.util.Log;
import android.view.View;
import android.widget.ProgressBar;

import androidx.appcompat.app.AppCompatActivity;
import androidx.recyclerview.widget.RecyclerView;

import com.android.volley.DefaultRetryPolicy;
import com.android.volley.Request;
import com.android.volley.RequestQueue;
import com.android.volley.Response;
import com.android.volley.VolleyError;
import com.android.volley.toolbox.JsonObjectRequest;
import com.android.volley.toolbox.Volley;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import java.util.Timer;
import java.util.TimerTask;

public class DataActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_data);

         String TAG ="DataActivity";
         RecyclerView recyclerView=findViewById(R.id.recyclerView);
         recyclerView.setVisibility(View.INVISIBLE);



         ProgressBar progressBar=findViewById(R.id.progressBar);

        RequestQueue requestQueue= Volley.newRequestQueue(this); //luodaan requestQueue ja aloitetaan se

        //url osoite ytj rajapintaan, jonka perään laitetaan hakusana
        String URL = "http://avoindata.prh.fi/bis/v1?totalResults=false&maxResults=30&resultsFrom=0&name=";

        Bundle extras = getIntent().getExtras();
        if (extras == null) {
            return;
        }
        // get data via the key
        String hakusana = extras.getString("Hakusana");
        if (hakusana != null) {
        // do something with the data
            URL=URL+hakusana; //muokataan url käyttäjän hakusanan mukaan

            JsonObjectRequest jsonObjectRequest = new JsonObjectRequest
                    (Request.Method.GET, URL, null, new Response.Listener<JSONObject>() {

                        @Override
                        public void onResponse(JSONObject response) {
                            try {
                                JSONArray responseItems=(JSONArray) response.getJSONArray("results") ;

                                for (int i = 0; i < responseItems.length(); i++) {
                                    JSONObject x=responseItems.getJSONObject(i);
                                    Log.i(TAG, String.valueOf(x.getString("name")));  //tulostaa hakuehdon täyttävien yritysten nimet consoliin
                                }

                                progressBar.setVisibility(View.INVISIBLE);
/*
                                adapter = new AdapterClass(responseItems);
                                adapter.notifyDataSetChanged();
                                recyclerView.setAdapter(adapter);*/

                                Log.e(TAG,String.valueOf(responseItems.length()));
                            } catch (JSONException e) {
                                throw new RuntimeException(e);
                            }

                        }

                    }, new Response.ErrorListener() {

                        @Override
                        public void onErrorResponse(VolleyError error) {
                            // TODO: Handle error

                        }
                    });

            jsonObjectRequest.setRetryPolicy(new DefaultRetryPolicy(10 * 1000, 1, 1.0f));
            requestQueue.add(jsonObjectRequest);
        }

                Timer timer = new Timer();
                timer.schedule(new TimerTask() {
                    @Override
                    public void run() {
                        // This code will be executed after the timer expires
                        progressBar.setVisibility(View.INVISIBLE);
                       // recyclerView.setVisibility(View.VISIBLE);
                    }
                }, 5000); // The timer will expire after 5 seconds (5000 milliseconds)

    }
}