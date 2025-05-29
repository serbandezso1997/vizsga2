<?php

namespace App\Http\Requests;

use Illuminate\Foundation\Http\FormRequest;
use Illuminate\Http\Exceptions\HttpResponseException;
use Illuminate\Contracts\Validation\Validator;
use Carbon\Carbon;

class RentalRequest extends FormRequest
{
    /**
     * Determine if the user is authorized to make this request.
     */
    public function authorize(): bool
    {
        return true;
    }

    /**
     * Get the validation rules that apply to the request.
     *
     * @return array<string, \Illuminate\Contracts\Validation\ValidationRule|array<mixed>|string>
     */
    public function rules(): array
    {
        return [
            "startDate"=>"after:today",
            "endDate"=>[function ($attribute, $value, $fail){

                $startDate = Carbon::parse($request("startDate"));
                $endDate = Carbon::parse($value);

                if($endDate-> lessthan($startDate->addDays(5)) ||
                $endDate->greaterthan($startDate->addDays(90))){
                    $fail("Foglalási időpontok nem megfelelőek!");
                }
            }]


        ];
    }

    public function failedValidation( Validator $validator ) {
 
    throw new HttpResponseException( response()->json([
        "success" => false,
        "message" => "Adatbeviteli hiba",
        "error" => $validator->errors()
    ]),400);
}
}
