<?php

namespace App\Http\Controllers;

use Illuminate\Http\Request;
use App\Http\Requests\RentalRequest;
use App\Models\Rental;

class RentalController extends Controller
{
    //

    public function getAllRental(){
        $rental = Rental::All();

        return response()->json($rental);
    }

    public function getRentalById(RentalRequest $request, $id){
        $rental = Rental::find($id);
        return response()->json($rental);
    }

    public function postRental (RentalRequest $request){

        $request->validated();

        $rental = Rental::where("yachtId", $request["yachtId"])
        ->where("startDate","<=",$request["endDate"])
        ->where("endDate",">=", $request["startDate"])->get();

        if(count($rental) > 0){
            return response()->json(["error"=>"Van foglalás a megadott időszakra!"]);
        }

        $rent = Rental::create(
            [
                "uid"=> $request["uid"],
                "yachtId"=> $request["yachtId"],
                "startDate" =>$request["startDate"],
                "endDate"=>$request["endDate"],
                "dailyPrice" => $request["dailyPrice"],
                "deposit" => $request["deposit"]
            ]
        );

        return response()->json($rent);
    }


    public function removeRental($id){
        $rental = Rental::find($id)->delete();
    }


}
