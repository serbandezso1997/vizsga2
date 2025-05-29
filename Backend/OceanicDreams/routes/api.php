<?php

use Illuminate\Http\Request;
use Illuminate\Support\Facades\Route;
use App\Http\Controllers\RentalController;

Route::get('/user', function (Request $request) {
    return $request->user();
})->middleware('auth:sanctum');

Route::get("/berlesek", [RentalController::class, "getAllRental"]);
Route::get("/berlesek/{id}", [RentalController::class, "getRentalById"]);
Route::post("/berlesek", [RentalController::class, "postRental"]);
Route::delete("/berlesek/{id}", [RentalController::class, "removeRental"]);


