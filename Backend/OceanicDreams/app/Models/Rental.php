<?php

namespace App\Models;

use Illuminate\Database\Eloquent\Model;

class Rental extends Model
{
    //
    protected $fillable=[
        "uid","yachtId","startDate","endDate","dailyPrice","deposit"
    ];
}
